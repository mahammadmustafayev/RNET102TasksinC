using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Models
{
    public class Employee
    {
       public string   FirstName { get; set; }
       public string   LastName { get; set; }
       public string   Mail { get; set; }
       public string   Address { get; set; }
       public string   City { get; set; }
       public DateTime BirthDate { get; set; }
       public DateTime HireTime { get; set; }
       public string   Linkedin { get; set; }
        private byte _age;
       public byte     Age 
        { 
            get 
            {
                return _age;
            } 
            set 
            {
                if (value<18)
                {
                    throw new Exception("Duz yas daxil edin(18)");
                }
                _age = value;
                
            } 
        }
        
    }
}
