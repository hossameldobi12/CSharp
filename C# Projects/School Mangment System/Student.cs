using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Mangment_System
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Student(int id, string name, List<Course> courses)
        {
            Id = id;

            Name = name;

            Courses = courses;
        }
        public Student(int id, string name)
        {
            Id = id;

            Name = name;
            Courses = new List<Course>();
        }
        public bool AddCourse(Course course)
        {
            if (course == null || (Courses.Contains(course)))
            {
                return false;
            }
            Courses.Add(course);
            return true;

        }
        public bool DeleteCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
                return true;

            }

            return false;
            
        }
        

        public void DeleteAllCourse()
        {
            Courses.Clear();

        }

        public override string ToString()
        {
            return $"Student id {Id} ,student Name {Name} , Student Courses {String.Join(" , ", Courses)} ";
        }
    }
}