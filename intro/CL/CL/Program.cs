using CL.Models;

namespace CL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Employee employee = new Employee();
            //employee.FirstName="Mehemmed";
            //employee.LastName = "Mustafayev";
            //employee.Age = 17;
            //Console.WriteLine($"""
            //                 Name:{employee.FirstName}
            //                 Surname:{employee.LastName}
            //                 Age:{employee.Age}
            //                 """); 
            #endregion
            
            Weapon keles = new Weapon();
            keles.BulletCapacity = 90;
            keles.CurrentBulletCapacity = 90;
            keles.FireMode = true;
            //keles.Fire();
            keles.Shoot();
            Console.WriteLine(keles.GetRemainBulletCount());
            keles.Fire();
            Console.WriteLine(keles.GetRemainBulletCount());
            keles.Reload();
            keles.Shoot();
        }
    }
}