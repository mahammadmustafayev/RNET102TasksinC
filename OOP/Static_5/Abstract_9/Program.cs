using Abstract_9.Models;
using Spectre.Console;
using System.Collections;
using System.Reflection;

namespace Abstract_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new();
            piano.Brand = "Yamaha";
            piano.Model = "CFX Piano";
            piano.Price = 3.88232100M;
            piano.Length = "9.0";

            Muzisyen pianost = new Muzisyen();
            pianost.FirstName = "Hamza";
            pianost.LastName = "Piyanov";
            pianost.Enstruman = piano;

            Muzisyen kemanci = new Muzisyen()
            {
                FirstName = "Hamza",
                LastName = "Kemansoy",
                Enstruman = new Keman
                {
                    Brand = "Yamaha",
                    Model = "YSV104BRO",
                    Price = 38.03400M,
                    Arse = "Hao Yun arse"
                }
            };
            Muzisyen gitarci = new Muzisyen()
            {
                FirstName="Valeh",
                LastName="Amirbakov",
                Enstruman= new Gitar
                {
                    Brand="Yamaha",
                    Model="FS800",
                    Price=220,
                    MagneticArray="H-H"
                }
            };
            Muzisyen fulut = new()
            {
                FirstName = "Korkut",
                LastName = "AtaBala",
                Enstruman = new YanFlut
                {
                    Brand="Yamaha",
                    Model="Kend isi",
                    Price=300,
                    Material="gumus"
                }
            };

            var muzisyenler = new ArrayList();
            muzisyenler.Add(kemanci);
            muzisyenler.Add(pianost);
            muzisyenler.Add(fulut);
            muzisyenler.Add(gitarci);

            foreach (var muzisyen in muzisyenler)
            {
                Console.WriteLine(muzisyen.GetType().Name +"\n");
                foreach (var property in muzisyen.GetType().GetProperties())
                {
                    if (property.PropertyType.Name != nameof(Enstruman))
                    {
                        Console.WriteLine($"{" ",10}{property.Name,-20} : {property.GetValue(muzisyen)}");
                        
                    }
                    else
                    {
                        Console.WriteLine(property.Name);
                        var items=property.GetValue(muzisyen,null);
                        foreach (var enstr in items.GetType().GetProperties())
                        {
                            Console.WriteLine($"{" ",10}{enstr.Name,-20} : {enstr.GetValue(items)}");
                        }
                        var functions=items
                                    .GetType()
                                    .GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)
                                    .Where(x=>!x.Name.StartsWith("get")&& !x.Name.StartsWith("set")).ToList();
                        foreach (var function in functions)
                        {

                           var val=  function.Invoke(items, null);
                            Console.WriteLine($"{" ",10}{function.Name,-20} : {val.ToString()}");

                        }

                    }


                }
                Console.WriteLine("\n"+ new string('_', 50)+"\n");

            }



            //var table = new Table();

            //foreach (var item in piano
            //                     .GetType()
            //                     .GetProperties())
            //{
            //    //Console.WriteLine(item.Name + " " + item.GetValue(piano));
            //    table.AddColumn(item.Name);
            //    table.AddColumn(new TableColumn(item.Name).Centered());


            //}
            //    AnsiConsole.Write(table);


            //Console.WriteLine(kemanci.Enstruman.Sound());

        }
    }
}