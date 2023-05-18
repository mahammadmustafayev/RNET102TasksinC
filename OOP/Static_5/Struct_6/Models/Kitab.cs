using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_6.Models
{
    internal class Kitab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BasimIli { get; set; }
        public string  AuthorName { get; set; }
        public int KitabPage { get; set; }
        public string ISBNNo { get; set; }
        public string YayinEvi { get; set; }
    }
    public struct Book
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BasimIli { get; set; }
        public string AuthorName { get; set; }
        public int KitabPage { get; set; }
        public string ISBNNo { get; set; }
        public string YayinEvi { get; set; }
    }
}
