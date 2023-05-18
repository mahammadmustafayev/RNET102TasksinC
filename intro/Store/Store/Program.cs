namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library();
            library.AddBook(new Book(
                name:"lotr",
                authorName:"novel",
                pageCount:400,
                price:15
                ));
            library.AddBook(new Book(
                name:"lotr",
                authorName:"novel",
                pageCount:300,
                price:5
                ));
            
            library.AddBook(new Book(
                name: "Anna Karenina",
                authorName: "Leo Tolstoy",
                pageCount:400,
                price:20
                ));
            //Console.WriteLine(library.GetBook("lotr").ToString());
            Console.WriteLine(new string('-',30));
            foreach (var item in library.FindAllBooks("lotr"))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 30));
            
            foreach (var item in library.RemoveAllBooks("lotr"))
            {
                
            }



        }
    }
}