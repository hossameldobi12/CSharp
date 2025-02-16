namespace C_Advanced02
{
    internal class Program
    {
        static T[] RemoveDuplicates<T>(T[] array)
        {
            /*
        
             This C# code uses the Distinct method from the System.
             Linq namespace to remove duplicate elements from the array.
             The Distinct method returns a new array containing only the unique elements.

              */
            return array.Distinct().ToArray();
        }

        static void Main(string[] args)
        {
            /*
             
            *****************************************************************************************************
            *                                                                                                   *
            * 5- Given an array, implement a function to remove duplicate elements from an array.               *
            *                                                                                                   *  
            *****************************************************************************************************
            
            int[] arr = new int[] { 1, 2, 2, 3, 3, 4 };
            int[] newARR = RemoveDuplicates(arr);
            foreach (var i in newARR)
            {
                Console.WriteLine(i);
            }

                        ************************************** THE END OF TASK ******************************** 
                        
            
            // lambda expression
            int[] arr = new int[] { 1, 2, 2, 3, 3, 4 };
            arr.Where(num => num % 2 == 0);
          */          
            
            

        }
    }
}
