using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BL
{
    public class Client
    {
        public string m_FirstName;
        public string m_LastName;
        public string m_phoneNumFirstThree;
        public string m_phoneNum;
        public string m_zipCode;
        public DateTime m_dateOfBirth;
        public string m_country;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string PhoneNumFirstThree { get => m_phoneNumFirstThree; set => m_phoneNumFirstThree = value; }
        public string PhoneNum { get => m_phoneNum; set => m_phoneNum = value; }
        public string ZipCode { get => m_zipCode; set => m_zipCode = value; }
        public DateTime DateOfBirth { get => m_dateOfBirth; set => m_dateOfBirth = value; }
        public string Country { get => m_country; set => m_country = value; }

        public void Insert()
        {
           DAL.Client_Dal.Insert(m_FirstName, m_LastName, m_phoneNum,  m_dateOfBirth, m_zipCode, m_country);
        }
    }
}
