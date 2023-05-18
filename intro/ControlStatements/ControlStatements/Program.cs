

//string username = "admin";
//string password = "123";

//if (username == "admin")
//{
//    if (password=="123")
//    {
//        Console.WriteLine("Istifadeci girisi oldu");
//    }
//    else
//    {
//        Console.WriteLine("Istifadeci melumatlarini diqqet edin");
//    }
//}
//else
//{
//    Console.WriteLine("Istifadeci melumatlarini diqqet edin");
//}


using System.Diagnostics;
#region Time
//Console.WriteLine("--------------------");
//Console.WriteLine("Saniye daxil edin");
//double second = Convert.ToDouble(Console.ReadLine());
////1
//DateTime addtime = DateTime.Now.AddSeconds(second);

//while (addtime >= DateTime.Now)
//{
//}

//Console.WriteLine("Isledi");
////2

//Stopwatch stopwatch = Stopwatch.StartNew();
//while (stopwatch.Elapsed.Seconds<second)
//{

//}
//Console.WriteLine("Isledi");
#endregion
Console.WriteLine("Uzunluqu daxil edin");
int passwordLength = Convert.ToInt32(Console.ReadLine());
//1
//string key = Guid.NewGuid().ToString("d").Substring(1, passwordLength);
//Console.WriteLine(key);
//2
Random random = new Random();
for (int i = 0; i < passwordLength; i++)
{
    Console.Write(random.Next(i));
}
//Console.WriteLine(random.Next(passwordLength));
//char[] password = { '1', '2', '3','4','5','6','7','8','9','0' };
//for (; passwordLength < password.Length; passwordLength++)
//{
//    Console.Write(random.Next(passwordLength));
//}












