using DataBaseTask.Helpers;
using DataBaseTask.Helpers.Helpers;
using NUnit.Framework;

namespace DataBaseTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Get person's email and phone                    
            var personName = "Ken";
            var expectedEmail = "ken5@adventure-works.com";
            var person = RequestHelper.GetPerson(personName);
            var actualEmail = person.EmailAddresses.FirstOrDefault()?.EmailAddress1;
            Assert.AreEqual(expectedEmail, actualEmail);

            //Get product name by Id
            var expectedProductById = "Sport-100 Helmet, Red";
            var productId = 707;
            var actualProduct = RequestHelper.GetProduct(productId);
            Assert.AreEqual(expectedProductById, actualProduct.Name);

            //Get culture Id 
            var productModelId = 11;
            var expectedProductName = "Long-Sleeve Logo Jersey";            
            var actualProductByModelId = RequestHelper.GetProductName(productModelId);
            Assert.AreEqual(expectedProductName, actualProductByModelId.Name);

            //Get product name by vendor 
            var vendorName = "Australia Bike Retailer";
            var expectedProduct = "Thin-Jam Lock Nut 9";
            var productByVendor = RequestHelper.GetProductByVendor(vendorName);            
            Assert.AreEqual(expectedProduct, productByVendor.Name);

            //Get currency by currency code
            var currencyCode = "CAD";
            var actualCurrency = RequestHelper.GetCurrency(currencyCode);
            var expectedCurrencyName = "Canadian Dollar";
            Assert.AreEqual(expectedCurrencyName, actualCurrency.Name);

            //Add new person to table
            AddNewPersonHelper.AddPerson();

            //Modify person
            StoredProcedureHelper.ModifyPerson();
        }
    }
}










//Scaffold-DbContext "Server=DESKTOP-NU9KJPG\SQLEXPRESS;Database=AdventureWorks2019;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer