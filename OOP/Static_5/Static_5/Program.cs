using Static_5.Models;
using System.Xml.Linq;

namespace Static_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //string example = "   Qwer_t*y";
            ////CharacterExtension(example);

            //example = example.MyLower();
            //Console.WriteLine(example); 
            #endregion
        }
        
    }
    #region StaticMethod
    static class Helpers
    {
        /// <summary>
        ///  Oz Cevirme sistemimiz
        /// </summary>
        /// <param name="param">ozu deyer tutur</param>
        /// <returns></returns>
        public static string MyLower(this string param)
        {
            return param.ToLower()
                   .Replace(" ", "")
                   .Replace("/", "")
                   .Replace("-", "")
                   .Replace("_", "")
                   .Replace(";", "")
                   .Replace("*", "")
                   .Replace(":", "")
                   .Replace("$", "");
        }
    } 
    #endregion
}