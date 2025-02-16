namespace OOPTaskLecture04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] p = new Point[3]
            {
                new Point() {X = 5 , Y = 6 , Z = 7},
                new Point() {X = 1 , Y = 2 , Z =3 },
                new Point() {X = 4 , Y = 9 ,Z  = 10}
        };
            foreach (Point p2 in p)
            {
                Console.WriteLine(p2);
            
            }

            Array.Sort(p);

            foreach (Point p2 in p)
            {
                Console.WriteLine(p2);
            }

        }
    }
}
