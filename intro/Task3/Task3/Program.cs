namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("------------------");
            //Console.WriteLine("Bir text daxil edin:");
            //string text = Console.ReadLine().Trim().ToLower();
            //int sum = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a'
            //        || text[i] == 'e'
            //        || text[i] == 'u'
            //        || text[i] == 'i'
            //        || text[i] == 'o')
            //    {
            //        ++sum;
            //    }
            //}
            //Console.WriteLine(text.Length - sum);
            #endregion
            #region Task2
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Birinci ededi daxil edin:");
            //int first=int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Ikinci ededi daxil edin");
            //int second=int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1: (+) Toplama");
            //Console.WriteLine("2: (-) Cixma");
            //Console.WriteLine("3: (*) Vurma");
            //Console.WriteLine("4: (/) Bolme");
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Bir eded secin");
            //int choise =int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------");
            //switch (choise)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine($"Cavab:{first}+{second}");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine($"Cavab:{first}-{second}");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine($"Cavab:{first}*{second}");
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine($"Cavab:{first}/{second}");
            //            break;
            //        }
            //    default :
            //        {
            //            Console.WriteLine("Sehv secim");
            //            break;
            //        }
            //}
            #endregion
            #region Task 3
            Console.WriteLine("----------------");
            Console.WriteLine("Bir ay daxil edin:");
            string month=Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Bir il daxil edin");
            int year=int.Parse(Console.ReadLine());
          
            switch (!string.IsNullOrWhiteSpace(month) && DateTime.Now.Year<=year )
            {
                case true:
                {
                        switch (month)
                        {
                            case "yanvar":
                            case "mart":
                            case "may":
                            case "iyul":
                            case "avqust":
                            case "oktyabr":
                            case "dekabr":
                                {
                                    Console.WriteLine("31 gun");
                                    break;
                                }
                            case "fevral":
                                {
                                    if (DateTime.IsLeapYear(year))
                                    {
                                        Console.WriteLine("28 gun");
                                    }
                                    else
                                    {
                                        Console.WriteLine("29 gun");
                                    }
                                    break;
                                }
                            case "aprel":
                            case "sentyabr":
                            case "noyabr":
                                {
                                    Console.WriteLine("30 gun");
                                    break;
                                }
                            default:
                                Console.WriteLine("Wrong");
                                break;
                        }
                        break;
                }
                default:
                    {
                        Console.WriteLine("Wrong");
                        break;
                    }
            }
            #endregion
        }
    }
}