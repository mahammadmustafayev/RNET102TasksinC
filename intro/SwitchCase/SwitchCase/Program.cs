using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch
            //string userName = "admin";
            //string password = "123";
            //if (userName=="admin")
            //{
            //    Console.WriteLine("Correct Login");
            //}
            //else
            //{
            //    Console.WriteLine("You can not login");
            //}
            //Console.WriteLine("---------------------------");
            //switch (userName)
            //{
            //    case "admin":
            //        {
            //            Console.WriteLine("Giris etdiniz");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Giris ede bilmediniz");
            //            break;
            //        }
            //}
            #endregion
            #region Switch-Task
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Fesil adi yazin");
            //string season=Console.ReadLine();
            //switch (season.Trim().ToLower())
            //{
            //    case "kis":
            //    {
            //            Console.WriteLine("Aralik");
            //            Console.WriteLine("Ocak");
            //            Console.WriteLine("Subat");
            //            break;
            //    }
            //    case "ilkbahar":
            //    {
            //            Console.WriteLine("Mart");
            //            Console.WriteLine("Nisan");
            //            Console.WriteLine("Mayis");
            //            break;
            //    }
            //    case "yaz":
            //    {
            //            Console.WriteLine("Haziran");
            //            Console.WriteLine("Temmuz");
            //            Console.WriteLine("Aqustos");
            //            break;
            //    }
            //    case "sonbahar":
            //    {
            //            Console.WriteLine("Eylul");
            //            Console.WriteLine("Ekim");
            //            Console.WriteLine("Kasim");
            //            break;
            //    }
            //    default:
            //    {
            //            Console.WriteLine("Bele secim yoxdur");
            //            break;
            //    }
            //}
            #endregion
            #region Switch-Month
            //Console.WriteLine("--------------");
            //Console.WriteLine("Zehmet olmasa bir ay daxil edin");
            //string month=Console.ReadLine().Trim().ToLower();
            //switch (!string.IsNullOrWhiteSpace(month))
            //{
            //    case true:
            //        {
            //            switch (month)
            //            {
            //                    case "dekabr":
            //                    case "yanvar":
            //                    case "fevral":
            //                    {
            //                        Console.WriteLine("Kis fesli");
            //                        break;
            //                    }
            //                case "mart":
            //                case "aprel":
            //                case "may":
            //                    {
            //                        Console.WriteLine("Yaz fesli");
            //                        break;
            //                    }
            //                case "iyun":
            //                case "iyul":
            //                case "avqust":
            //                    {
            //                        Console.WriteLine("Yay fesli");

            //                        break;
            //                    } 
            //                case "oktyabr":
            //                case "sentyabr":
            //                case "noyabr":
            //                    {
            //                        Console.WriteLine("Payiz fesli");

            //                        break;
            //                    }
            //                default:
            //                    Console.WriteLine("Bele ay yoxdur");
            //                    break;
            //            }
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Deyer daxil edin");
            //            break;
            //        }
            //}
            #endregion
            #region Switch Bal
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Zehmet olmasa puan dahil  edin");
            //string note=Console.ReadLine();

            //switch (!string.IsNullOrWhiteSpace(note))
            //{
            //    case true:
            //        {
            //            int _note=int.Parse(note);
            //            switch ( _note )
            //            {
            //                case int n when n>=0 && n<=100:
            //                    {
            //                        break;
            //                    }
            //                default:
            //                    {

            //                        break;
            //                    }
            //            }
            //            break;
            //        }

            //    default:
            //        {
            //            Console.WriteLine("Duz data yazin");
            //            break;
            //        }
            //}
            #endregion
            #region SwitchColor
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Bir ingilizce reng daxil edin");
            //string color= Console.ReadLine().Trim().ToLower();
            //if (!string.IsNullOrWhiteSpace(color))
            //{
            //    switch (color)
            //    {
            //        case "red":
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Kirmizi");
            //            Console.ResetColor();
            //            break;
            //        }
            //        case "white":
            //        {
            //            Console.WriteLine("Beyaz");
            //            break;
            //        }
            //        case "green":
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Yasil");
            //            Console.ResetColor();
            //            break;
            //        } 
            //        case "yellow":
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            Console.WriteLine("Sari");
            //            Console.ResetColor();
            //            break;
            //        }
            //        case "blue":
            //        {
            //                Console.ForegroundColor = ConsoleColor.Blue;

            //                Console.WriteLine("Qara");
            //                Console.ResetColor();
            //            break;
            //        }
            //        case "brown":
            //        {
            //            Console.WriteLine("Qehveyi");
            //            break;
            //        }
            //        default:
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Bele bir reng yoxdur");
            //            Console.ResetColor();
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Duzgun daxil edin");
            //    Console.ResetColor();
            //}
            #endregion
            #region Ctrl+K+s
            // Ctrl+K+s
            #endregion
            #region  Switchexpetion
            //Console.WriteLine("-----------");
            //string? color = Console.ReadLine().Trim().ToLower() switch
            //{
            //    "red" => "qirmizi",
            //    "green" => "Yasil",
            //    _ => "Wrong"
            //} ; 
            //Console.WriteLine(color);
            #endregion
            #region Ternary
            //int yash = 17;
            //string? ifResult = "";
            //if (yash>=18)
            //{
            //    ifResult = "Gire biler";
            //}
            //else
            //{
            //    ifResult = "Gire bilmez";
            //}
            //Console.WriteLine(ifResult);
            //Console.WriteLine(yash>=18 ? "true":"false");
            //bool result = false;
            //Console.WriteLine($"Parametrde Gonderdiqiniz Kayit Eklen{(result ? "":"me")}di");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(
                               number >=0 && number <=10 ? "Kirmizi" 
                              :number>=11 && number <=20 ? "Mavi"
                              :number>=21 && number <=30 ? "Sari"
                              :number>=31 && number <=40 ? "Yesil"
                              :"Wrong");
            #endregion
        }

    }
}