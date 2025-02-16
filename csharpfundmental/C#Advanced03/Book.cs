using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, Decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            string authors = string.Join(",", Authors);
            string publicationdate = PublicationDate.ToString("G");
            return $"ISBN : {ISBN} , Title {Title} , Authors {authors} , PublicationDate {publicationdate} , Price {Price}  ";
        }

    }
}
