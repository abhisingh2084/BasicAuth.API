using BasicAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API
{
    public class ValidateUser
    {

        // Checking User Exist or not
        public static bool Login(string username, string password)
        {
           return User.GetUsers().Any(user => user.UserName.Equals(username) && user.Password == password );
        }

        //Get User Details

        public static User GetuserDetails(string username, string password)
        {
            return User.GetUsers().FirstOrDefault(user => user.UserName.Equals(username) && user.Password == password);
        }
    }
}