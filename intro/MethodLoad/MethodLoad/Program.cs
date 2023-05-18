namespace MethodLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OutTask
            //Console.WriteLine(Val(6));

            //Num('/', 4, 5, out int result);
            //Console.WriteLine(result);

            //var result = Test(6, 2);
            //Console.WriteLine(result.toplam);
            //Console.WriteLine(result.bolum);
            //Console.WriteLine(result.carpim);
            //Console.WriteLine(result.farq);
            //Console.WriteLine(result.mod); 
            #endregion
            int[] n= { 1, 2, 3 };
            AddResize(ref n, 2);
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
        }

        public static void AddResize(ref int[] n,int size)
        {
            int[] m = new int[n.Length+1];
            if (size > 0 && n != null)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    m[i] = n[i];

                }
                m[n.Length] = size;
                n = m;
                //int res=n.Length+size;
                //n = new int[res];
            }
        }

        public static int Val(int num) 
        {
            if (num == 0) return 0;
            else if (num%2==0) return -1;
            return 1;
        }
        #region OutRef

        public static void Num(char control ,int n, int m,out int res)
        {
            res = 0;
            switch (control) 
            {
                case '+':
                    {
                        res = n+m;
                        break;
                    }
                case '-':
                    {
                        res = n-m;
                        break;
                    }
                case '*':
                    {
                        res = n*m;
                        break;
                    }
                case '/':
                    {
                        res = n/m;
                        break;
                    }
                case '%':
                    {
                        res = n%m;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Seh parametr");
                        break;
                    }
            }
            
        }
        //Tuple 
        #region TupleMethod
        public static (int toplam, double bolum, long carpim, int farq, int mod) Test(int n, int m)
        {
            return (
                 toplam: n + m,
                 bolum : n / m,
                 carpim: n * m,
                 farq  : n - m,
                 mod   : n % m
                );
        } 
        #endregion
        #endregion
    }
}