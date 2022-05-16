using System;
using System.Collections.Generic;

#nullable disable

namespace InventoryApp.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public User(int userId, string firstName, string lastName, string companyName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
        }

        public User()
        {
            
        }
    }
}
