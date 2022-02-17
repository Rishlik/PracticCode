using PracAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracAPI.Models
{
    public class ResponceModel
    {
        public ResponceModel(Staff staff)
        {
            Id = staff.id;
            FirstName = staff.FirstName;
            LastName = staff.LastName;
            Passport = staff.Passport;
            Phone = staff.Phone;
            Email = staff.Email;
            Login = staff.Login;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }

    }
}