using System.Security.Cryptography.X509Certificates;

namespace FuncAndAction;

public class Program
{
    public static string ToMail(string firstName, string lastName) => $"{firstName}.{lastName}@code.edu.az";
    public static string ToCard(string firstName, string lastName) => $"FirstName:{firstName,-10}\nLastName:{lastName}";
    public static string ToSaveDB(string firstName, string lastName) => $"FirstName:{firstName,-10}\nLastName:{lastName}\nAddress to database";

    public delegate string SavePersonTocompany(string firstName, string lastName);
    public static void CreatePerson(string firstName, string lastName,SavePersonTocompany savePerson)
    {
        var create= new SavePersonTocompany(ToMail);
        create += ToCard;
        create += ToSaveDB;
        create.Invoke(firstName, lastName);
    }
    public static void UpdatePerson(string firstName, string lastName,SavePersonTocompany savePerson)
    {
        var update= new SavePersonTocompany(ToMail);
            update += ToCard;
            update += ToSaveDB;
            update.Invoke(firstName, lastName);
    }










    public static    void    DelegateVoidMethodV1(string text) { Console.WriteLine(text); }
    public static   string   DelegateStringMethodV1(string text)
    {
        Console.WriteLine($"DelegateStringMethodV1 ->{text}");
        return text;
    }
    public static   string   DelegateStringMethodV2(string text) => $"DelegateStringMethodV2 ->{text}";
    public static   string   FunctionReturnMethod() => "https://contoso.com";
    public delegate string   DelegateFunction(string text);
    public delegate void   DelegateFunctionVoid(string text);


    public static  Func<string,bool> CustomControl()
    {
        
        return x => x.Length > 10 && x.Length < 20;
    }

    public static void Main(string[] args)
    {
        #region Example
        //DelegateFunction delegateFunction = DelegateStringMethodV1;
        //delegateFunction.Invoke("Delegate method is working");

        //DelegateFunctionVoid dVoid = new DelegateFunctionVoid(DelegateVoidMethodV1);
        //CustomControl("Mehemmed");
        //List<string> domainNames = new()
        //{
        //    "code.edu.az",
        //    "hotmail.com",
        //    "azure.com"
        //};
        //var names=domainNames
        //          .Where(x => x.Length > 10 &&x.Length<20)
        //          .ToList();

        //var names = domainNames
        //           .Where(CustomControl())
        //           .ToList();

        //foreach (var item in names)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion
        //var voidDelegate = new DelegateFunctionVoid(DelegateStringMethodV1);
        Func<string> getDomainName = () => "code";
        getDomainName += () => "hotmail.com";
        var t = getDomainName();
        Console.WriteLine(t);
    }
}