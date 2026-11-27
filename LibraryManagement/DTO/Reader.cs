using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Độc giả (bảng Users). Balance là số dư quỹ</summary>
    internal class Reader
    {
        public int ID { get; set; }
        public string FullName { get; set; } = "";
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }

        public Reader() { }

        public Reader(DataRow row)
        {
            ID = Convert.ToInt32(row["UserID"]);
            FullName = row["FullName"].ToString() ?? "";
            BirthDate = row["BirthDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["BirthDate"]);
            Gender = row["Gender"].ToString() ?? "";
            PhoneNumber = row["PhoneNumber"].ToString() ?? "";
            Email = row["Email"].ToString() ?? "";
            Address = row["Address"].ToString() ?? "";
            Balance = Convert.ToDecimal(row["Balance"]);
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]);
        }

        public Reader(string fullName, DateTime? birthDate, string gender, string phoneNumber, string email, string address, decimal balance, DateTime createdAt)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Balance = balance;
            CreatedAt = createdAt;
        }
    }
}
