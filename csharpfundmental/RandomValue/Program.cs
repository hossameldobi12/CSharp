

using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {



        const string buffer_capital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string buffer_small = "abcdefghijklmnopqrstuvwxyz";
        const string buffer_number = "0123456789";
        const string buffer_symplo = "*/-+&%$#@!";


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select an option");
                Console.WriteLine("[1] generate random number     [2] generte random string");
                var selcted_option = Console.ReadLine();
                if (selcted_option == "1")
                {
                    generateRandomValue();
                }
                else if (selcted_option == "2")
                {
                    generateCustomizValue();
                }
            }

        }
        static void generateRandomValue()
        {
            var rand = new Random();
            var Random_value = rand.Next(1000, 9999);
            Console.WriteLine(Random_value);
        }
        static void generateCustomizValue()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder buffer_user = new StringBuilder();
            Random rand = new Random();
            bool flag = true;
            Console.WriteLine("Do you need capital letter");
            Console.WriteLine("[1] yes         [2] No");
            var capital = Console.ReadLine();
            if (capital == "1")
            {
                sb.Append(buffer_capital);
            }
            Console.WriteLine("Do you need small letter");
            Console.WriteLine("[1] yes         [2] No");
            var small = Console.ReadLine();
            if (small == "1")
            {
                sb.Append(buffer_small);
            }
            Console.WriteLine("Do you need number letter");
            Console.WriteLine("[1] yes         [2] No");
            var number = Console.ReadLine();
            if (number == "1")
            {
                sb.Append(buffer_number);
            }
            Console.WriteLine("Do you need sympol");
            Console.WriteLine("[1] yes         [2] No");
            var sympol = Console.ReadLine();
            if (sympol == "1")
            {
                sb.Append(buffer_symplo);
            }
            try
            {
                if (capital == "2" && small == "2" && number == "2" && sympol == "2")
                {
                    throw new Exception("you must chosse at least one choise");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                flag = false;

            }
            while ((buffer_user.Length < 16) && (flag == true))
            {
                var randomindex = rand.Next(0, sb.Length - 1);
                buffer_user.Append(sb[randomindex]);
            }
            Console.WriteLine(buffer_user);



        }
    }
};





