using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        // Gets card from sql database using stored procedure
        public  Card GetCard(string citizenshipId,int pin)
        {
            // Database connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ATM")))
            {
                // The string parameter is stored procedure from database 
                var output = connection.Query<Card>("dbo.Card_GetByCitizenID_and_Pin @CitizenshipID, @Pin", new { CitizenshipID = citizenshipId, Pin = pin }).ToArray();
                if (output.Length > 0)
                    return output[0];
                else
                    return null;
            }
        }

        // Gets person from sql database using stored procedure
        public Person GetPerson(int Id)
        {
            // Database connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ATM")))
            {
                // The string parameter is stored procedure from database 
                var output = connection.Query<Person>("dbo.People_GetByID @PersonID", new { PersonID = Id}).ToArray();
                if (output.Length > 0)
                    return output[0];
                else
                    return null;
            }
        }

        // Gets card from sql database using stored procedure
        public Card GetCard(int Id)
        {
            // Database connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ATM")))
            {
                // The string parameter is stored procedure from database 
                var output = connection.Query<Card>("dbo.Card_GetByID @id", new { id = Id }).ToArray();
                if (output.Length > 0)
                    return output[0];
                else
                    return null;
            }
        }

        // Update card balance in sql database using stored procedure
        public void UpdateBalance(float balance,int Id)
        {
            // Database connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ATM")))
            {
                // The string parameter is stored procedure from database 
                connection.Execute("dbo.Card_Update_Balance @Balance, @id", new { Balance = balance, id = Id});
            }
        }
    }
}
