using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Enum_8.Models
{
    public enum Status : byte
    {
        None = 0,

        [Display(Name ="Aktif kullanicilari listeler")]
        Active = 1,

        [Display(Name = "Passive kullanicilari listeler")]
        Passive,

        [Display(Name = "Deleted kullanicilari listeler")]
        Deleted,

        [Display(Name = "Holiday kullanicilari listeler")]
        Holiday
    }
    public class Customer
    {
        public Status Status { get; set; }

        public void GetDisplayName()
        {
            var properties= typeof(Status).GetFields();
            foreach (var pp in properties)
            {
                var da=pp.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
                if (da != null)
                {
                    Console.WriteLine(pp.Name+" -> "+da.Name);
                }
            }
        }
    }
}
