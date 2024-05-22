using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Email { get; set; }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User{Id=1011, UserName = "NormalUser", Password="12345", Roles="User", Email="User@gmail.com"},
                new User{Id=1012, UserName = "AdminUser", Password="12345", Roles="User,Admin", Email="User@gmail.com"},
                new User{Id=1013, UserName = "SuperUser", Password="12345", Roles="User, Admin,SuperAdmin", Email="User@gmail.com"}
            };
            return users;

        }
    }
}