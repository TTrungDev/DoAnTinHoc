using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DTO
{
    public class Book
    {
        private int iD;
        private string title;
        private int authorID;
        private int categoryID;
        private int publisherID;
        private int publishyear;
        private int quantity;
        private int available;
        private string description;
        //private DateTime createdDate;
        public Book(DataRow row)
        {
            this.iD = (int)row["BookID"];
            this.title = (string)row["Title"];
            this.authorID = (int)row["AuthorID"];
            this.categoryID = (int)row["CategoryID"];
            this.publisherID = (int)row["PublisherID"];
            this.publishyear = (int)row["PublishYear"];
            this.quantity = (int)row["Quantity"];
            this.available = (int)row["Available"];
            this.description = (string)row["Description"];
            //this.createdDate = (DateTime)row["CreatedDate"];
        }
        public Book(int iD, string title, int authorID, int categoryID, int publisherID, int publishyear, int quantity, int available, string description, DateTime createdDate)
        {
            this.iD = iD;
            this.title = title;
            this.authorID = authorID;
            this.categoryID = categoryID;
            this.publisherID = publisherID;
            this.publishyear = publishyear;
            this.quantity = quantity;
            this.available = available;
            this.description = description;
            //this.createdDate = createdDate;
        }
        public int ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value; }
        public int AuthorID { get => authorID; set => authorID = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public int PublisherID { get => publisherID; set => publisherID = value; }
        public int Publishyear { get => publishyear; set => publishyear = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Available { get => available; set => available = value; }
        public string Description { get => description; set => description = value; }
        //public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
