using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03
{
    internal static class BookFunctions
    {
        public static string GetTitle (Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string authors = string.Join (",", B.Authors);
            return authors;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
