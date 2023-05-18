using System.IO;

namespace FileTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Qovluq ucun ad daxil edin:");
            string folderName=Console.ReadLine();
            string path = @"C:\Users\mahammadvm\Desktop\intro\File\File";
            Directory.CreateDirectory(path+ @"\"+folderName);
            int choise;
            do
            {
                Console.WriteLine("1-Create");
                Console.WriteLine("2-File Delete");
                Console.WriteLine("3-Add info File");
                Console.WriteLine("4-ShowInfo");
                Console.WriteLine("5-Search Value");
                Console.WriteLine("6-Music");
                Console.WriteLine("7-Exit");
                choise = int.Parse(Console.ReadLine());
                Console.WriteLine("Fayl adi daxil edin");
                string fileName=Console.ReadLine();
                switch (choise)
                {
                    case 1:
                        {
                                                   
                            File.Create(Path.Combine(path, folderName, fileName +".txt"));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Silinecek Faylin adini daxil edin");
                            string deleteFileName = Console.ReadLine();
                            Console.WriteLine("C:\\Users\\mahammadvm\\Desktop\\intro\\File\\File\\q\\j.txt");
                            string res = Path.Combine(path, folderName, deleteFileName +".txt");
                            //File.Delete(res);
                            Console.WriteLine("Islemir");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Yazi daxil edin:");
                            string text=Console.ReadLine();
                            File.WriteAllText(Path.Combine(path, folderName, fileName + ".txt"), text);
                            break;
                        }
                    case 4:
                        {
                            //foreach (var line in File)
                            //{
                            //    Console.WriteLine(line);
                            //}
                            break;
                        }
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong choise");
                        Console.ResetColor();
                        break;
                }
            } while (choise !=7);
        }
    }
}