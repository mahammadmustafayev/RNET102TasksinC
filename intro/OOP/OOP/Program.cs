using System.IO;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1();
            FileInfo();
            #region params
            //double[] price = { 1, 3, 12.45, 34 };
            //double sum=  Calculate(price);
            //Console.WriteLine(sum);
            //string name = "Mahammad";
            //string surname = "Mustafayev";
            //Console.WriteLine(Payment(name, surname, 1, 5, 3.5)); 
            #endregion
        }
        #region Params
        //public static double Calculate(double[] items)
        //{
        //    return Enumerable.Sum(items);
        //}
        //public static string Payment(string name,string surname,params double[] money)
        //{
        //    double pay=Enumerable.Sum(money);
        //    string result = $"Musteri:" +
        //                    $"Sayin {name} {surname}" +
        //                    $"Toplam odemeniz lazim olan tutar:{pay} AZN";
        //    return result;
        //} 
        #endregion
        
        public static void Example1()
        {
            string[] user =
            {
                "mahammadvm@code.edu.az",
                "Mahammad Mustafayev",
                "+9949999999",
                "Baki",
                "Azerbaycan"
            };
            string filePath = @"C:\Users\mahammadvm\Desktop\intro\OOP\OOP\Files\example1.txt";
            File.WriteAllLinesAsync(filePath, user);

            foreach (var line in File
                .ReadAllLines(filePath)
                .Select((value,i)=>new {value,i}))
            {
                Console.WriteLine($"{line.i + 1}->{line.value}");
            }
        }
        public static void FileInfo()
        {
            string filePath = @"C:\Users\mahammadvm\Desktop\intro\OOP\OOP\Files\example1.txt";
            string folderPath = @"C:\Users\mahammadvm\Desktop\intro\OOP\OOP\Files";
            DirectoryInfo info = new DirectoryInfo(folderPath);
            FileInfo[] files = info.GetFiles(searchPattern:"*.txt",searchOption:SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"""
                    FileName->{file.Name}
                    File Length->{file.Length}
                    File Directory->{file.DirectoryName}
                    """);
                
            }
        }
        
    }
}