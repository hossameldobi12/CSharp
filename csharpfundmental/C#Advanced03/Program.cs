using System.Reflection.Metadata.Ecma335;
using static C_Advanced03.LibraryEngine;

namespace C_Advanced03
{
    internal class Program
    {
     
        
        static void Main(string[] args)
        {
            
            Book SevenDays = new Book("111", "SevenDays", ["Hossam", "Adel"], new DateTime(2001, 1, 1, 1, 1, 1), 21);
            Book SixDays = new Book("222", "SixDays", ["Hesham", "Adel"], new DateTime(2002, 2, 2, 2, 2, 2), 22);
            Book FiveDays = new Book("333", "FiveDays", ["Ahmed", "Adel"], new DateTime(2003, 3, 3, 3, 3, 3), 23);
            Book FourDays = new Book("444", "SevenDays", ["Emad", "Adel"], new DateTime(2004, 4, 4, 4, 4, 4), 24);
            List<Book> list = new List<Book>() { SevenDays, SixDays, FiveDays, FourDays };
            Console.WriteLine(SevenDays);
            Console.WriteLine(BookFunctions.GetPrice(SevenDays));
            Console.WriteLine(BookFunctions.GetTitle(SevenDays));
            Console.WriteLine(BookFunctions.GetAuthors(SevenDays));

            // using user defined Delegate 

            BookPointer ptr = BookFunctions.GetAuthors;

            ProcessBook(list, ptr);

            //using Built in Delegate

            Func<Book, string> func = BookFunctions.GetPrice;
            ProcessBook(list, func);

            //Anonymous Method

            Func<Book,string>func01 = delegate (Book B) {return B.ISBN;};
            ProcessBook(list, func01);

            //lambda expression
            Func<Book, string> func02 = b => b.PublicationDate.ToString("G");
            ProcessBook(list,func02);

            

            
            

        }

    }
}
