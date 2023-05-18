using Generic_12.Models;
using System.Reflection;

namespace Generic_12;

static class Program
{
    #region GenericMethod
    public static void WriteProductToConsole(List<Product> entities)
    {

        foreach (var entity in entities)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name,-15}:{property.GetValue(entity)}");

            }
        }
    }

    public static void WriteCategoryToConsole(List<Category> entities)
    {
        foreach (var entity in entities)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name,-15}:{property.GetValue(entity)}");

            }
        }
    }
    public static void WriteToConsole<T>(List<T> entities) where T : IEntity
    {

        foreach (var entity in entities)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name,-15}:{property.GetValue(entity)}");

            }
        }
    } 
    #endregion
    public static T GenerateClass<T>(Dictionary<string,object> document) where T : IEntity, new()
    {
        
        T t = new();
        foreach (var property in t.GetType().GetProperties())
        {
            foreach (var entity in document)
            {
                if (entity.Key == property.Name)
                {
                    //property.SetValue(t, entity.Value);
                    property.SetValue(t, Convert.ChangeType(entity.Value,property.PropertyType));
                    //Console.WriteLine($"{property.Name}:{property.GetValue(t)}");
                }
            }
        }

        return t;
    }

    public static T GenericClassV2<T>(Dictionary<string,object> document,T type) where T: IEntity,new()
    {
        var instance = new T();
        foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (document.TryGetValue(property.Name, out object value))
            {
                property.SetValue(instance, Convert.ChangeType(value, property.PropertyType));
            }
        }
        return instance;
    }
    public static T GenericClassV2<T>(Dictionary<string,object> document,Type type) where T: IEntity,new()
    {
        var instance = Activator.CreateInstance(type);
        foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (document.TryGetValue(property.Name,out object value))
            {
                property.SetValue(instance,Convert.ChangeType(value,property.PropertyType));
            }
        }
        return (T)instance;
    }

    public static Dictionary<string,object> GetDictionary<T>(this T className )
    {
        Dictionary<string,object> dict = new Dictionary<string,object>();
        foreach (var property in className.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
           dict.Add(property.Name,property.GetValue(className));
        }
        return dict;
    }
    static void Main(string[] args)
    {

        Dictionary<string, object> employee = new()
        {
            {"FirstName","Murat" },
            {"LastName","Vuranok" },
            {"Mail","murat.vuranok@code.edu.az"},
            {"Phone","+905323520997" }
        };

        Dictionary<string, object> categories = new()
        {
            {"CategoryId", 1 },
            {"CategoryName","Beverages" },
            {"Description","Sweet and savory sauces" }
        };

        Dictionary<string, object> products = new()
        {
            {"Id ",1 },
            {"Name","Chai" },
            {"Price",18.00M },
            {"UnitsInStock", 39 }
        };


        
        //Category cay = GnericClassV2(categories, new Category());
        //Category cay = GenericClassV2<Category>(categories, typeof(Category));

        //WriteToConsole(Category.Categories);
        //Product prod = GenerateClass<Product>(products);

        Employee emp = GenericClassV2<Employee>(employee,typeof(Employee));
        foreach (var item in emp.GetType().GetProperties())
        {
            Console.WriteLine(item.Name + ":" + item.GetValue(emp));
        }

        Console.WriteLine("\nToDicitonary \n");
        foreach (var item in GetDictionary(emp))
        {
            Console.WriteLine(item.Key+":"+item.Value);
        }
    }
}