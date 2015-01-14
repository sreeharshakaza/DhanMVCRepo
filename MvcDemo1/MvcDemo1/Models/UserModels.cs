using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo1.Models
{
    public class UserModels
    {
        [Display(Name="First Name")]
        public string Firstname { get; set; }
        public string LastName{ get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public Decimal Salary { get; set; }
    }

    public class Users
    {
        public Users()
        {
            userList.Add(new UserModels { 
                Firstname = "Dhan",
                LastName = "Siwach",
                Address = "Jaipur",
                Email = "dhan@jaipur.com",
                DOB = DateTime.Today,
                Salary = 70000
            });

            userList.Add(new UserModels
            {
                Firstname = "Dhan1",
                LastName = "Siwach1",
                Address = "Jaipur",
                Email = "dhan1@jaipur.com",
                DOB = DateTime.Today,
                Salary = 75000
            });

            userList.Add(new UserModels
            {
                Firstname = "Dhan2",
                LastName = "Siwach2",
                Address = "Jaipur",
                Email = "dhan2@jaipur.com",
                DOB = DateTime.Today,
                Salary = 80000
            });

            userList.Add(new UserModels
            {
                Firstname = "Dhan3",
                LastName = "Siwach3",
                Address = "Jaipur",
                Email = "dhan3@jaipur.com",
                DOB = DateTime.Today,
                Salary = 85000
            });
        }

        public List<UserModels> userList = new List<UserModels>();

        public void AddUser(UserModels userModel)
        {
            userList.Add(userModel);
        }
    }
}