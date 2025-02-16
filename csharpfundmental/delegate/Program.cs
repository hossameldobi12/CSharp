namespace Delegate
{

    internal class Program
    {
        public static void PrintArary<T>(T[] arr )
        {
            Console.WriteLine();
            foreach (T i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] Arr = {9,5,6,4,8,7,3,2,1};
            string[] Names = { "Ahmed", "Ali", "Hossam" };
            DelgateCompare<int> x = SortingConditional.CompareDce;
            DelgateCompare<string> y = SortingConditional.CompareString;

            //PrintArary(Arr);
            //SortingAlgorithms.BubbleSortDce(Arr);
            //SortingAlgorithms.BubbleSort(Arr,x);
            //PrintArary(Arr);

            PrintArary(Names);
            SortingAlgorithms.BubbleSort(Names, y);
            PrintArary(Names);

            


    }
    }
}
