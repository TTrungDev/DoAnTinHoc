using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DTO
{
    internal class Category
    //public class Category
    {
        private int iD;
        private string name;
        private string description;

        public Category(DataRow row)
        {
            this.ID = (int)row["CategoryID"];
            this.Name = (string)row["CategoryName"];
            this.Description = (string)row["Description"];
        }
        public Category(int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }

        public int ID 
        { 
            get { return iD; } 
            set { iD = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
