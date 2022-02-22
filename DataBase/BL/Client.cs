using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataBase.DAL;

namespace DataBase.BL
{
    public class Client
    {
        private int m_ID;
        private string m_firstName;
        private string m_lastName;
        private string m_phoneNum;
        private string m_zipCode;
        private DateTime m_dateOfBirth;
        private string m_country;
        private City m_City; //חדש
        private Company m_Company;




        public int ID { get => m_ID; set => m_ID = value; }
        public string FirstName { get => m_firstName; set => m_firstName = value; }
        public string LastName { get => m_lastName; set => m_lastName = value; }
        public string PhoneNum { get => m_phoneNum; set => m_phoneNum = value; }
        public string ZipCode { get => m_zipCode; set => m_zipCode = value; }
        public DateTime DateOfBirth { get => m_dateOfBirth; set => m_dateOfBirth = value; }
        public string Country { get => m_country; set => m_country = value; }
        public City City { get => m_City; set => m_City = value; } //חדש

        public Company Company { get => m_Company; set => m_Company = value; }



        public bool Insert()
        {
           return Client_Dal.Insert(m_firstName, m_lastName, m_phoneNum, m_dateOfBirth, m_zipCode, m_country, m_City.ID);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_firstName = dataRow["FirstName"].ToString();
            m_lastName = dataRow["LastName"].ToString();
            m_phoneNum = dataRow["PhoneNum"].ToString();
            m_dateOfBirth = (DateTime)dataRow["DateOfBirth"];
            m_zipCode = dataRow["ZipCode"].ToString();
            m_country = dataRow["Country"].ToString();
            m_City = new City(dataRow.GetParentRow("ClientCity"));
            m_Company= new Company(dataRow.GetParentRow("ClientCompany"));

        }

        public bool Update()
        {
            return Client_Dal.Update(m_ID, m_firstName, m_lastName, m_phoneNum, m_dateOfBirth, m_zipCode, m_country, m_City.ID);
        }

        public bool Delete()
        {
            return Client_Dal.Delete(m_ID);
        }

        public override string ToString()
        { return $"{m_lastName} {m_firstName}"; }



    }
}