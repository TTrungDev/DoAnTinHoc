using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DTO
{
    internal class Reader
    {
        private int iD;
        private string fullName;
        private DateTime birthDate;
        private string gender;
        private string phoneNumber;
        private string email;
        private string address;
        private double balance;
        private DateTime createdAt;

        public Reader(DataRow row)
        {
            //this.ID = (int)row["UserID"];
            this.FullName = (string)row["FullName"];
            this.BirthDate = (DateTime)row["BirthDate"];
        }


        public Reader(string fullName, DateTime birthDate, string gender, string phoneNumber, string email, string address, double balance, DateTime createdAt)
        {
            this.FullName = fullName;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
            this.Balance = balance;
            this.CreatedAt = createdAt;
        }

        public int ID { get => iD; set => iD = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public double Balance { get => balance; set => balance = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}
