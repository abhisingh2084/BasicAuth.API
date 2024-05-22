using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1, FirstName = "Aryan", LastName = "Saxena", Gender = "Male", City = "Pune", IsActive = true },
                new Employee{Id=2, FirstName = "Ayush", LastName = "Singh", Gender = "Male", City = "Sasaram", IsActive = true },
                new Employee{Id=3, FirstName = "Vikash", LastName = "Pal", Gender = "Male", City = "Patna", IsActive = true },
                new Employee{Id=4, FirstName = "Sagar", LastName = "Sabrawal", Gender = "Male", City = "Solipath", IsActive = true },
                new Employee{Id=5, FirstName = "Rohit", LastName = "Maurya", Gender = "Male", City = "Agra", IsActive = true }
            };
            return employees;   
        }
    }
}