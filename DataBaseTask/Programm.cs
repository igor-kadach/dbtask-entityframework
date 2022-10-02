using DataBaseTask.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace DataBaseTask
{ 
    public class Programm
    {


          static void Main(string[] args)
          {
               //using var dbContext = new DBContext();

            //Get person's email and phone
           // var peoplePhoneEmail = dbContext.People.Include(p => p.PersonPhones).Include(p => p.EmailAddresses).Select(p => p.FirstName).Where(p => p == "Ken").ToList();

           // string actualPerson = peoplePhoneEmail[0];

            

            string expectedPerson = "Ken";
            Assert.AreEqual(expectedPerson, Helpers.GetPersonEmail());



            //Get product name by Id
            //    var product = dbContext.Products.Include(p => p.ProductCostHistories).Where(p => p.ProductId == 707).Select(p => p.Name).ToList();

            //    string actualProduct = product[0];
            //    string expectedProduct = "Sport-100 Helmet, Red";
            //    Assert.AreEqual(expectedProduct, actualProduct);

            //    //Get product id photo 
            //    var productPhoto = dbContext.ProductPhotos.Include(p => p.ProductProductPhotos).OrderBy(p => p.ModifiedDate).Select(p => p.ProductPhotoId).Take(10).ToList();

            //    var actualProductPhoto = productPhoto[5];
            //    var expectedProductPhoto = 118;
            //    Assert.AreEqual(expectedProductPhoto, actualProductPhoto);

            //    //Get product name by vendor 
            //    var productVendor = dbContext.Products.Include(p => p.ProductVendors).Select(p => p.ProductNumber).Distinct().Take(5).ToList();

            //    var actualProductVendor = productVendor[1];
            //    var expectedProductVendor = "BA-8327";
            //    Assert.AreEqual(expectedProductVendor, actualProductVendor);

            //    //Get currency by currency code
            //    var currency = dbContext.Currencies.Include(c => c.CountryRegionCurrencies).Where(c => c.CurrencyCode == "eur" || c.CurrencyCode == "de").Select(c => c.Name).Take(5).ToList();

            //    var actualCurrency = currency[0];
            //    var expectedCurrency = "EURO";
            //    Assert.AreEqual(expectedCurrency, actualCurrency);

            //    //Add new person to table
            //    var person = new Person()
            //    {
            //        PersonType = "IN",
            //        FirstName = "FirstName",
            //        MiddleName = "MiddleName",
            //        LastName = "MiddleName",
            //        Suffix = "Suffix",
            //        BusinessEntity = new BusinessEntity()
            //    };
            //    dbContext.People.Add(person);
            //    dbContext.SaveChanges();


            Helpers.ModifyPerson();

            //    //Stored Procedures/Modiffy person 
            //    SqlParameter param = new("@BusinessEntityID", 1);
            //    SqlParameter param1 = new("@NationalIDNumber", 295847284);
            //    SqlParameter param2 = new("@BirthDate", System.Data.SqlDbType.DateTime);
            //    param2.Value = DateTime.Now.AddYears(-20);
            //    SqlParameter param3 = new("@MaritalStatus", "S");
            //    SqlParameter param4 = new("@Gender", "F");

            //    dbContext.Database.ExecuteSqlRaw("[HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID,@NationalIDNumber,@BirthDate,@MaritalStatus,@Gender",
            //                          param, param1, param2, param3, param4);



        }
    }
}







//Scaffold-DbContext "Server=DESKTOP-NU9KJPG\SQLEXPRESS;Database=AdventureWorks2019;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer
