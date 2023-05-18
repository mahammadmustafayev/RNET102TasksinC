using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
     class Book
     {

        #region Constructor
        public Book(string name, string authorName, int pageCount, double price)
        {
            this.Name = name;
            this.AuthorName = authorName;
            this.PageCount = pageCount;
            this.Price = price;
            
        }
        #endregion

        private int _pageCount;
        private double _price;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount 
        { 
            get 
            {
                return _pageCount;
            } 
            set 
            {
                if (value>0)
                {
                    _pageCount = value;
                }
            } 
        }
        public double Price { get => _price; 
            set 
            {
                if (_price>0)
                {
                    _price = value;
                }
            } 
        }
        public string Code { get; set; }
        public override string ToString()
        {
            return $"{Name}-{AuthorName}";
        }
        
    }
}
