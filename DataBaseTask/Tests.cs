using DataBaseTask.Helpers;
using DataBaseTask.Helpers.Helpers;
using NUnit.Framework;

namespace DataBaseTask
{
    public class Tests
    {
        static void Main(string[] args)
        {
            //Get person's email and phone                    
            string expectedPerson = "Ken";
            Assert.AreEqual(expectedPerson, RequestHelper.GetPersonEmail());

            //Get product name by Id
            string expectedProduct = "Sport-100 Helmet, Red";
            Assert.AreEqual(expectedProduct, RequestHelper.GetProductName());

            //Get product id photo
            var expectedProductPhoto = 118;
            Assert.AreEqual(expectedProductPhoto, RequestHelper.GetIdPhoto());

            //Get product name by vendor 
            var expectedProductVendor = "BA-8327";
            Assert.AreEqual(expectedProductVendor, RequestHelper.GetProductNameByVendor());

            //Get currency by currency code
            var expectedCurrency = "EURO";
            Assert.AreEqual(expectedCurrency, RequestHelper.GetCurrency());

            //Add new person to table
            AddNewPersonHelper.AddPerson();

            //Modify person
            StoredProcedureHelper.ModifyPerson();
        }
    }
}










//Scaffold-DbContext "Server=DESKTOP-NU9KJPG\SQLEXPRESS;Database=AdventureWorks2019;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer