using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    internal class Library
    {
        private Book[] _book= new Book[0];
        public Book[] Book { get => _book; set => _book = value; }
        public void AddBook(Book book)
        {
            Array.Resize(ref _book, _book.Length+1);
            _book[_book.Length-1] = book;
        }
        public Book GetBook(string bookName)
        {
            return Array.Find(_book,x=>x.Name==bookName);
        }
        public Book[] FindAllBooks(string name)
        {
            return Array.FindAll(_book, x => x.Name == name);
        }
        public Book[] RemoveAllBooks(string name) 
        {
            _book = _book.Where(x=>x.Name!=name).ToArray();
            return _book;
        }
    }
}
