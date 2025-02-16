using System.Collections;

namespace C_Advanced01
{
    internal class Program
    {
        public static void ReverseList(ArrayList list)
        {
            int right = list.Count - 1;
            int left = 0;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {

            /*
            Ranges<int> range = new Ranges<int>(5, 10);
            Console.WriteLine(range.length());
            Console.WriteLine(range.ValueIsInRange(8));
            */

            /*
            *****************************************************************************************************
            *                                                                                                   *
            * 2-you are given an ArrayList containing a sequence of elements.                                   *
            * try to reverse the order of elements in the ArrayList in-place                                    *
            * (in the same arrayList) without using the built-in Reverse.                                       *
            * Implement a function that takes the ArrayList as input and                                        *
            * modifies it to have the reversed order of elements.                                               *    
            *                                                                                                   *  
            *****************************************************************************************************

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4 });
            list.Add("mohamed");
            ReverseList(list);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

                          ************************************** THE END OF TASK ******************************** 
            */

            try
            {


                FixedSizeList<string> FixedSize = new FixedSizeList<string>(5);
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");
                FixedSize.Add("hossam");

                string name = FixedSize.Get(8);
                Console.WriteLine(name);
            }
            catch (Exception e )
            {
                Console.WriteLine(e.ToString());
            }

            
        }
    }
}
