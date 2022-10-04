using DataBaseTask.Models;

namespace DataBaseTask.Helpers
{
    public class AddNewPersonHelper
    {
        public static void AddPerson()
        {
            using var dbContext = new DBContext();

            var person = new Person()
            {
                PersonType = "IN",
                FirstName = "FirstName",
                MiddleName = "MiddleName",
                LastName = "MiddleName",
                Suffix = "Suffix",
                BusinessEntity = new BusinessEntity()
            };
            dbContext.People.Add(person);
            dbContext.SaveChanges();
        }
    }
}