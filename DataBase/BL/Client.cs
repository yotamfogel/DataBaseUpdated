using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase.BL
{
    public class Client
    {
        private int m_ID;
        private string m_FirstName;
        private string m_LastName;
        private string m_phoneNumFirstThree;
        private string m_phoneNum;
        private string m_zipCode;
        private DateTime m_dateOfBirth;
        private string m_country;
        private City m_City;

        public int ID { get => m_ID; set => m_ID = value; }
        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string PhoneNumFirstThree { get => m_phoneNumFirstThree; set => m_phoneNumFirstThree = value; }
        public string PhoneNum { get => m_phoneNum; set => m_phoneNum = value; }
        public string ZipCode { get => m_zipCode; set => m_zipCode = value; }
        public DateTime DateOfBirth { get => m_dateOfBirth; set => m_dateOfBirth = value; }
        public string Country { get => m_country; set => m_country = value; }

        public City City { get => m_City; set => m_City = value; }




        public bool Insert()
        {
           return DAL.Client_Dal.Insert(m_FirstName, m_LastName, m_phoneNum,  m_dateOfBirth, m_zipCode, m_country);
        }

        public bool Update()
        {
            return DAL.Client_Dal.Update(m_ID, m_FirstName, m_LastName, m_phoneNum,m_dateOfBirth, m_zipCode, m_country);
        }

        public Client() { }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_phoneNum = dataRow["PhoneNum"].ToString();
            m_dateOfBirth = (DateTime)dataRow["DateOfBirth"];
            m_zipCode = dataRow["ZipCode"].ToString();
            m_country = dataRow["Country"].ToString();
            m_City = new City(dataRow.GetParentRow("ClientCity"));
        }

        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }
        public bool Delete()
        {
            return DAL.Client_Dal.Delete(m_ID);
        }

    }
}
