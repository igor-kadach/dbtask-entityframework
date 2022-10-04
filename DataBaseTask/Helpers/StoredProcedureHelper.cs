using DataBaseTask.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataBaseTask.Helpers.Helpers
{
    public class StoredProcedureHelper
    {
        public static void ModifyPerson()
        {
            using var dbContext = new DBContext();

            SqlParameter param = new("@BusinessEntityID", 1);
            SqlParameter param1 = new("@NationalIDNumber", 295847284);
            SqlParameter param2 = new("@BirthDate", System.Data.SqlDbType.DateTime);
            param2.Value = DateTime.Now.AddYears(-20);
            SqlParameter param3 = new("@MaritalStatus", "S");
            SqlParameter param4 = new("@Gender", "F");

            dbContext.Database.ExecuteSqlRaw("[HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID,@NationalIDNumber,@BirthDate,@MaritalStatus,@Gender",
                                  param, param1, param2, param3, param4);
        }
    }
}