using System.Collections;
using System.Linq;

namespace DayFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array.Length
            //string[] names = { "Valeh", "Mehemmed","Samir" };
            //Console.WriteLine(names[names.Length - 1]);

            #endregion
            #region Randomherf
            //char[] letters = { 'a', 'b', 'c', 'f', 'y','z','m','n' };
            //Random random = new Random();
            //int result=random.Next(letters.Length);
            //Console.WriteLine(letters[result]);


            #endregion
            #region Array

            //string[] cities =
            //{
            //    "baki",
            //    "ankara",
            //    "eskisehir",
            //    "kastamonu",
            //    "eskisehir",
            //    "edirne",
            //    "bursa",
            //    "baki",
            //    "sivas",
            //    "artvin",
            //    "baki"
            //};

            //string val = "baki";
            //if (Array.IndexOf(cities,val) != Array.LastIndexOf(cities, val))
            //{
            //    Console.WriteLine("Isleyir");
            //}
            //else 
            //{
            //    Console.WriteLine("Islemir");
            //}
            ////Array.Clear(cities);
            #endregion
            #region Task1-Day5
            //string[] trible = { "dsa", "asd", "yui", "opl" };
            //string result = string.Join(",", trible);
            //Console.WriteLine(result);

            #endregion
            #region Task2-Day5
            //Console.WriteLine("---------------");
            //Console.WriteLine("Eded daxil edin");
            //int entered=int.Parse(Console.ReadLine());
            //int[] numbers = {1,2,3,4,5};

            //bool result = Array.Exists(numbers,x=>x==entered);
            //Console.WriteLine(result);

            //bool res=numbers.Contains(entered);
            //Console.WriteLine(res);
            #endregion
            #region Task3-Day5
            //Console.WriteLine("Reqem daxil edin");
            //int entered=int.Parse(Console.ReadLine());
            //int[] arr= new int[0];
            //Array.Resize(ref arr, arr.Length + 1);
            //arr[arr.Length - 1] = entered;
            //Console.WriteLine($" Arrayin uzunluqu:{arr.Length}");

            #endregion
            #region Task4-Day5
            //Console.WriteLine("-----------------");
            //string param = Console.ReadLine();
            //string[] values = { "qwerty", "yul","trew"};
            //Array.FindAll(values, arr => arr != param);

            //if (Array.IndexOf(values, param) != Array.LastIndexOf(values,param) )
            //{
            //    Array.ReferenceEquals(values, param);
            //    Console.WriteLine("silindi");
            //}
            //else
            //{
            //    Console.WriteLine("islemedi");
            //}

            #endregion
            #region Task1-Day6
            //Console.WriteLine("-------------");
            //string word=Console.ReadLine().Trim().ToLower();
            //string[] names = {"mehemmed","esed","samir"};
            //bool result=  Array.Exists(names, x=>x==word);
            //Console.WriteLine($"{word} yazisi names arrayinin icerisinde {(result?"Vardir":"Yoxdur")}");
            #endregion
            #region Loops
            //for (int i = 1; i < 1000; i++) {  Console.WriteLine(i);}

            //for (int i =1000 ; i >= 1; i--){Console.WriteLine(i);}

            //for (int i = 0; i < 1000; i+=2)
            //{

            //        Console.WriteLine(i);
            //}

            //for (char i = 'a'; i <='z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int sum = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //for (int i = 1945; i <= DateTime.Now.Year; i++) 
            //{
            //    if (i !=1990 && i!=1992 ) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion
            #region Task 2-Day6

            //Console.WriteLine("-------------");
            //string[]  products = new string[0];


            //int choise;
            //try
            //{
            //    do
            //    {
            //        Console.WriteLine("1-Create");
            //        Console.WriteLine("2-Read");
            //        Console.WriteLine("3-Update");
            //        Console.WriteLine("4-Delete");
            //        Console.WriteLine("5-Exit");
            //        choise = int.Parse(Console.ReadLine());
            //        switch (choise)
            //        {
            //            case 1:
            //                try
            //                {
            //                    Array.Resize(ref products, products.Length + 1);
            //                    Console.WriteLine("Bir productin adini daxil edin:");
            //                    string newProductName = Console.ReadLine();
            //                    products = products.Append(newProductName).ToArray();
            //                    break;
            //                }
            //                catch (Exception)
            //                {
            //                    throw new Exception("Xeta bas verdi");

            //                }
            //            case 2:
            //                try
            //                {
            //                    for (int i = 0; i < products.Length; i++)
            //                    {
            //                        Console.WriteLine("------------------------");
            //                        Console.Write(i + ":" + products[i]);
            //                        Console.WriteLine(" ");
            //                        Console.WriteLine("------------------------");
            //                    }
            //                    break;
            //                }
            //                catch (Exception)
            //                {
            //                    throw new Exception("Xeta bas verdi");

            //                }
            //            case 3:
            //                {
            //                    try
            //                    {
            //                        Console.WriteLine("Axtardiqiniz productun indexini yazin");
            //                        int searchingProductId = int.Parse(Console.ReadLine());
            //                        bool result = products.Contains(products[searchingProductId]);
            //                        if (result)
            //                        {
            //                            Console.WriteLine("Editlemek istediyiniz product adini daxil edin:");
            //                            string editProductName = Console.ReadLine();
            //                            products[searchingProductId] = editProductName;

            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Bele index yoxdur");
            //                        }
            //                        break;
            //                    }
            //                    catch (Exception exc)
            //                    {

            //                        throw new Exception("xeta bas verdi");
            //                    }


            //                }
            //            case 4:
            //                {
            //                    try
            //                    {
            //                        Console.WriteLine("Silmek istediyiniz id-ni daxil edin:");
            //                        int deletedId = int.Parse(Console.ReadLine());
            //                        products = products.Where((val, res) => res != deletedId).ToArray();
            //                        break;
            //                    }
            //                    catch (Exception)
            //                    {

            //                        throw new Exception("xeta bas verdi");
            //                    }

            //                }
            //            case 5:
            //                {
            //                    try
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Green;
            //                        Console.WriteLine("Good Bye!");
            //                        Console.ResetColor();
            //                        break;
            //                    }
            //                    catch (Exception exc)
            //                    {

            //                        throw new Exception("xeta bas verdi");
            //                    }
            //                }
            //            default:
            //                Console.ForegroundColor = ConsoleColor.Red;
            //                Console.WriteLine("Bele secim yoxdur");
            //                Console.ResetColor();
            //                break;
            //        }
            //    } while (choise != 5);
            //}
            //catch (Exception exc)
            //{

            //    Console.WriteLine(exc.Message);
            //}
            #endregion
            #region Tasks-Day7

            //string[] team = {"besiktas","fenerbahce","galatasaray","trabzonspor","ankaragucu"};
            //for (int i = 0; i < team.Length; i++) 
            //{
            //    Console.WriteLine(team[i]);
            //}
            //int[] numbers = { 1, 2, 3, 4, 25, 6, 7, 8, 19, 10, 11, 12, 13, 14, 15, 16, 17 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers);
            //}
            //int tsum=0;
            //int csum=0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2==0)csum++;
            //    //else 
            //    tsum++;
            //}
            //Console.WriteLine($"Tek ededlerin sayi-{tsum} ededdir");
            //Console.WriteLine($"Cut ededlerin sayi-{csum} ededdir");

            //Console.WriteLine("--------------");
            //Console.WriteLine("Ad daxil edin:");
            //start:
            //try
            //{
            //    string word = Console.ReadLine().Trim();
            //    if (!string.IsNullOrEmpty(word) || !string.IsNullOrWhiteSpace(word))
            //    {
            //        Console.WriteLine("--------------");
            //        for (int i = word.Length - 1; i >= 0; i--)
            //        {
            //            Console.Write(word[i]);
            //        }
            //    }
            //}
            //catch (Exception )
            //{
            //    throw new Exception("Xeta bas verdi");
            //    goto start;

            //}

            //Console.WriteLine("-----------");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //   int n= num.CompareTo(i);
            //}
            //int sum = 0;
            //string number = Console.ReadLine();
            //for (int i = 0; i < number.Length; i++)
            //{

            //        sum += int.Parse(number[i].ToString());

            //}
            //Console.WriteLine(sum);
            //char test = 'x';
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(test);
            //}

            //char test2 = 'x';
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(test2);
            //}
            //char test= 'X';
            //int s = 0;
            //bool result=int.TryParse()
            //for (int i = 0; i <=10; i++)
            //{
            //    Console.Write(test);
            //}

            //string text = "";
            //if (int.TryParse(Console.ReadLine(), out int value))
            //{
            //    for (int i = 1; i <= value; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            text += "x";
            //        }
            //        text += "\n";
            //    }
            //    Console.WriteLine(text);
            //}



            #endregion
            #region Task-Day7

            //for (int i = 1; i <=10; i++)
            //{
            //    for(int j = 1; j <=10; j++)
            //    {
            //        string text = $"{i}*{j}={i*j}";
            //        Console.WriteLine(text);
            //    }
            //    Console.WriteLine(new String('-',30));
            //}

            #endregion
            #region forEach,while
            //string[] sehirler = {
            //"Adana",
            //"Adıyaman",
            //"Afyonkarahis",
            //"Ağrı",
            //"Aksaray",
            //"Amasya",
            //"Ankara",
            //"Antalya",
            //"Ardahan",
            //"Artvin",
            //"Aydın",
            //"Balıkesir",
            //"Bartın",
            //"Batman",
            //"Bayburt",
            //"Bilecik",
            //"Bingöl",
            //"Bitlis",
            //"Bolu",
            //"Burdur",
            //"Bursa",
            //"Çanakkale",
            //"Çankırı",
            //"Çorum",
            //"Denizli",
            //"Diyarbakır",
            //"Düzce",
            //"Edirne",
            //"Elazığ",
            //"Erzincan",
            //"Erzurum",
            //"Eskişehir",
            //"Gaziantep",
            //"Giresun",
            //"Gümüşhane",
            //"Hakkâri",
            //"Hatay",
            //"Iğdır",
            //"Isparta",
            //"İstanbul",
            //"İzmir",
            //"Kahramanmara",
            //"Karabük",
            //"Karaman",
            //"Kars",
            //"Kastamonu",
            //"Kayseri",
            //"Kırıkkale",
            //"Kırklareli",
            //"Kırşehir",
            //"Kilis",
            //"Kocaeli",
            //"Konya",
            //"Kütahya",
            //"Malatya",
            //"Manisa",
            //"Mardin",
            //"Mersin",
            //"Muğla",
            //"Muş",
            //"Nevşehir",
            //"Niğde",
            //"Ordu",
            //"Osmaniye",
            //"Rize",
            //"Sakarya",
            //"Samsun",
            //"Siirt",
            //"Sinop",
            //"Sivas",
            //"Şanlıurfa",
            //"Şırnak",
            //"Tekirdağ",
            //"Tokat",
            //"Trabzon",
            //"Tunceli",
            //"Uşak",
            //"Van",
            //"Yalova",
            //"Yozgat",
            //"Zonguldak" };


            //Console.WriteLine("----------------");
            //string username;
            //string password;
            //do
            //{

            //    Console.WriteLine("Istifadeci adini girin");
            //    username = Console.ReadLine().Trim().ToLower();
            //    Console.WriteLine("Parolu girin");
            //    password = Console.ReadLine().Trim().ToLower();

            //} while (username != "admin" && password != "123");





            //int[] nums = { 1, 7, 3 ,4,5,6,7,9,21,45};
            //int[] tnum = new int[0];
            //int[] cnum = new int[0];
            //foreach (int item in nums)
            //{
            //    if (item%2==0)
            //    {
            //        Array.Resize(ref cnum, cnum.Length+1);
            //        cnum[cnum.Length-1]=item;
            //    }
            //    else
            //    {
            //        Array.Resize(ref tnum, tnum.Length+1);
            //        tnum[tnum.Length-1]=item;

            //    }
            //}



            #endregion
            #region again
            //Console.WriteLine("edeler daxil edin");
            //string numbers=Console.ReadLine().Trim();
            //string[] nums= numbers.Split(' ');

            //Array.ForEach(nums, x =>
            //{
            //    if (int.Parse(x)%2!=0)
            //    {
            //        Console.Write(x+" ");
            //    }
            //});

            //int[] nums1 = { 1, 2, 3, 4, 5, 7 };
            //int[] nums2 ={ 1, 12, 3, 4, 4, 67 };

            //Console.WriteLine("Ferqli");
            //int[] nums= nums1.Union(nums2).Except(nums1.Intersect(nums2)).ToArray();

            //Console.WriteLine("Eyni");
            //int[] numss = nums1.Intersect(nums2).ToArray();

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}