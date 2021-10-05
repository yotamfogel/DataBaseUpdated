using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DAL
{
    class Client_Dal
    {
        static public void Insert(string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country)
        {
            string sql = $"INSERT INTO Table_Client (FirstName,LastName,PhoneNum,DateOfBirth,ZipCode,Country) VALUES ('{firstName}', '{lastName}', '{phoneNum}', '{dateOfBirth}', '{zipCode}', '{country}')";
            Dal.ExecuteSql(sql); 
        }
    }
    

}
