using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Transactions;

namespace TasklLecture02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 
            *****************************************************************************************************
            *                                                                                                   *
            * 2- write a c# program that convet string to an interger and string contain non numirc characters  *
            *                                                                                                   *  
            ***************************************************************************************************** 
            
              
            
            Console.WriteLine("please enter a sring contain numirc and non numirc characters");
            string input = Console.ReadLine();
            string ReturnNumberPart = ExtractNumberFromString(input);
            if (string.IsNullOrEmpty(ReturnNumberPart))
            {
                Console.WriteLine("the string does not contain a number characters");
            }
            else
            {
                int IntegerPart = int.Parse(ReturnNumberPart);
                Console.WriteLine($" the integer part is {IntegerPart} ");
            }

            string ExtractNumberFromString(string input)
            {
                string numberpart = string.Empty;
                foreach (var item in input)
                {
                    if (char.IsDigit(item))
                    {
                        numberpart += item;
                    }
                }
                return numberpart;
            }
            ************************************** THE END OF TASK ******************************** 
            */


            /** 
            *****************************************************************************************************
            *                                                                                                   *
            * 3 -write a c# program that perform a simple arthmatic operation with floating point numbers       *
            *                                                                                                   *  
            *****************************************************************************************************
            
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number one");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter number two");
            float num2 = float.Parse(Console.ReadLine());
            float result;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
                   }

                   ************************************** THE END OF TASK ******************************** 
                   
                */

            /**
            *****************************************************************************************************
            *                                                                                                   *
            * 4- write a c# program that extract substring from string                                          *
            *                                                                                                   *  
            *****************************************************************************************************
            

            Console.WriteLine("enter the string");
            string InputString = Console.ReadLine();
            Console.WriteLine("entre the range seperated by comma");
            string InputRange = Console.ReadLine();
            string[] range = InputRange.Split(",");
            int[] IntegerRange = new int[2];
            int counter = 0;

            foreach (var item in range)
            {
                IntegerRange[counter] = int.Parse(item);
                counter++;
            }
            counter = 0;
            if ((IntegerRange[0] < InputString.Length) && (IntegerRange[1] < InputString.Length))
            {
                string ResultString = InputString.Substring(IntegerRange[0], IntegerRange[1]);
                Console.WriteLine(ResultString);
            }
            else
            {
                Console.WriteLine("error in range");
            }

                   ************************************** THE END OF TASK ******************************** 
            */
            
           

        }
        
    }
}

