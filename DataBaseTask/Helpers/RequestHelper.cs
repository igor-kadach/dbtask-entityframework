using DataBaseTask.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseTask.Helpers
{
    public static class RequestHelper 
    {
        //Get person's email and phone                  
        public static string GetPersonEmail()
        {
            using var dbContext = new DBContext();

            var peoplePhoneEmail = dbContext.People.Include(p => p.PersonPhones).Include(p => p.EmailAddresses).Select(p => p.FirstName).Where(p => p == "Ken").ToList();
            string actualPerson = peoplePhoneEmail[0];
            return actualPerson;
        }

        //Get product name by Id
        public static string GetProductName()
        {
            using var dbContext = new DBContext();

            var product = dbContext.Products.Include(p => p.ProductCostHistories).Where(p => p.ProductId == 707).Select(p => p.Name).ToList();
            string actualProduct = product[0];
            return actualProduct;
        }

        //Get product id photo
        public static int GetIdPhoto()
        {
            using var dbContext = new DBContext();

            var productPhoto = dbContext.ProductPhotos.Include(p => p.ProductProductPhotos).OrderBy(p => p.ModifiedDate).Select(p => p.ProductPhotoId).Take(10).ToList();
            var actualProductPhoto = productPhoto[5];
            return actualProductPhoto;
        }

        //Get product name by vendor 
        public static string GetProductNameByVendor()
        {
            using var dbContext = new DBContext();

            var productVendor = dbContext.Products.Include(p => p.ProductVendors).Select(p => p.ProductNumber).Distinct().Take(5).ToList();
            var actualProductVendor = productVendor[1];
            return actualProductVendor;
        }

        //Get currency by currency code
        public static string GetCurrency()
        {
            using var dbContext = new DBContext();

            var currency = dbContext.Currencies.Include(c => c.CountryRegionCurrencies).Where(c => c.CurrencyCode == "eur" || c.CurrencyCode == "de").Select(c => c.Name).Take(5).ToList();
            var actualCurrency = currency[0];
            return actualCurrency;
        }
    }
}