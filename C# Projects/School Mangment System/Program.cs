namespace School_Mangment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c01 = new Course("C#", "Mohamed");
            Course c02 = new Course("C++", "Adel");
            Course c03 = new Course("Java", "Islam");
            Student s01  = new Student (1,"Hossam");
            Student s02  = new Student (2,"Mostafa");
            School school = new School ();
            school.AddStudent(s01);
            school.AddStudent(s02);
            school.AddCourse(c01);
            school.AddCourse(c02);
            school.AddStudentInCourse(s01, c03);
            s01.AddCourse(c01);
            s01.AddCourse(c02);
            Console.WriteLine(s01);
            s01.DeleteCourse(c01);
            Console.WriteLine(s01);
            s01.DeleteAllCourse();
            Console.WriteLine(s01);
            Console.WriteLine(school);


        }
    }
}
