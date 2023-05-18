using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwe.Models
{
    internal class Employee
    {
        public Employee()
        {
            
        }
        public Employee(string firstName)
        {
            this.FirstName = firstName;
        }
        public Employee(string firstName,string lastName):this(firstName)
        {
            this.LastName = lastName;
        }
        public Employee(string firstName,string lastName,string mail):this(firstName,lastName)
        {
            this.Mail = mail;
        }
        public Employee(string firstName,string lastName,string mail,string address):this(firstName,lastName,mail)
        {
            this.Address = address;
        }
        public Employee(string firstName,string lastName,string mail,string address,string phone):this(firstName,lastName,mail,address)
        {
            this.Phone = phone;
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public string?  Phone { get; set; }
        public DateTime HireTime { get; set; }

    }
}
