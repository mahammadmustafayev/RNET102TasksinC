namespace Methods
{
    internal class Program
    {
        #region Methods
        public static void Loto(int klon)
        {
            Random random = new Random();
            for (int i = 0; i < klon; i++)
            {
                string[] numbers = new string[6];
                int index = 0;
                while (index < numbers.Length)
                {
                    string num = random.Next(1, 50).ToString("D2");
                    if (!numbers.Contains(num))
                    {
                        numbers[index] = num;
                        index++;
                    }
                }
                Array.Sort(numbers);

                Console.WriteLine(string.Join(" - ", numbers));
            }
        }
        public static void Test(int n)
        {

        }
        public static void Email(string email)
        {
            var res = email.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public static void SaitV1(string text)
        {

            //char[] characters = text.ToLower().ToCharArray();
            char[] sait = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            int saitCount = 0;
            int samitCount = 0;
            foreach (var item in text)
            {
                if (sait.Contains(item))
                {
                    saitCount++;
                }
                else
                {
                    samitCount++;
                }

            }
            Console.WriteLine(saitCount);
            Console.WriteLine(samitCount);
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Ders
            //Loto(10);
            //Test(100);
            //Console.WriteLine("Zehmet olmasa mailleri daxil edin:");
            //string mail=Console.ReadLine();
            //Email(mail);
            //string val=Console.ReadLine().Trim().ToLower();
            //SaitV1(val); 
            #endregion
            //Min(10,1,2,3,4,5,6,54,23);
            //NumLength(1236575456);
            //HasLetter("salam", "sa");
            Sort(10, 1, 2, 3, 4, 5, 6, 54, 23);
            
        }
        public static void Min(params int[] numbers)
        {
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);

            int big = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<big)
                {
                    big = numbers[i];
                }
            }
            Console.WriteLine(big);
        }
        public static void NumLength(int n)
        {
            string res =n.ToString();
            int count = 0;
            for (int i = 0; i < res.Length; i++)
            {
                count++;
            }
            Console.WriteLine($"Ededlerin sayi:{count}");
        }
        /// <summary>
        /// Cevrenin Sahesi Dusturu
        /// </summary>
        /// <param name="r">Radius </param>
        public static void Area(double r)
        {
            Console.WriteLine($"Cevrenin Sahesi:{3.14*(r*r)}");
        }
        public static void Area(double a, double b)
        {
            Console.WriteLine($"Duzbucaqlinin Sahesi:{a * b}");
        } 
        public static void Area(double a, double b, double c)
        {
            Console.WriteLine($"Duzbucaqlinin Paralelpipedin Tam Sethinin Sahesi:{(a * b)+(a*c)+(b*c)}");
        }
        public static void Area(double r, double a, double b, double c)
        {   double p=(a+b+c)/2;
            Console.WriteLine($"Ucbucaqlinin Daxiline Cekilmis Cevrenin Sahesi:{p*r}");
        }

        public static void HasLetter(string text,string letter)
        {
            Console.WriteLine(text.Contains(letter)?"Vardir":"Yoxdur");
        }
        public static void Sort( params int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                       
                        numbers[i] = numbers[j]+numbers[i];
                        numbers[j] = numbers[i]-numbers[j];
                        numbers[i]= numbers[i]-numbers[j];
                        
                    }
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}