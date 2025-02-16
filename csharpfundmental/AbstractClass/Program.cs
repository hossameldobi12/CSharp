namespace AbstractClass
{
     
    internal class Program
    {
        static int symaaray(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
         static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(symaaray( ref numbers));
            Console.WriteLine(numbers[0]);
        }
    }
}
