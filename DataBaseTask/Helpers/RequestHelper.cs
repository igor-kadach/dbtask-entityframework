using DataBaseTask.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseTask.Helpers
{
    public static class RequestHelper 
    {
        //Get person                  
        public static Person GetPerson(string name)
        {
            using var dbContext = new DBContext();

            return dbContext.People.Include(p => p.PersonPhones).Include(p => p.EmailAddresses).First(p => p.FirstName == name);
        }

        //Get product name by Id
        public static Product GetProduct(int id)
        {
            using var dbContext = new DBContext();

            return dbContext.Products.Include(p => p.ProductCostHistories).First(p => p.ProductId == id);
        }

        //Get product name by ModelId
        public static ProductModel GetProductName(int productModelId)
        {
            using var dbContext = new DBContext();           

            return dbContext.ProductModels.Include(p => p.ProductModelProductDescriptionCultures).First(p => p.ProductModelId == productModelId);        
        }

        //Get product name by vendor 
        public static Product GetProductByVendor(string vendorName)
        {
            using var dbContext = new DBContext();

            return dbContext.Products.Include(p => p.ProductVendors).First(p => p.ProductVendors.Select(pv => pv.BusinessEntity.Name).Contains(vendorName));           
        }

        //Get currency by currency code
        public static Currency GetCurrency(string code)
        {
            using var dbContext = new DBContext();

            return dbContext.Currencies.Include(c => c.CountryRegionCurrencies).First(c => c.CurrencyCode == code);
        }
    }
}