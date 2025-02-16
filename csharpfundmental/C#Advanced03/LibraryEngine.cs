using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced03
{
    internal class LibraryEngine
    {

        public delegate string BookPointer(Book book);
        
        //For user defined Delegate
        public static void ProcessBook(List<Book> books  ,BookPointer ptr )
        {
            foreach(Book book in books ) 
                {
                 Console.WriteLine(ptr(book));
                }
        }

        //For built in delegate
        public static void ProcessBook(List<Book> books, Func<Book,string> ptr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(ptr(book));
            }
        }
    }
}

