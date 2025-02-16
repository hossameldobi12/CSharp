using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Mangment_System
{
    internal class School
    {
        List<Student> Students { get; set; }
        List<Course> Courses { get; set; }

        public School(List<Student> students, List<Course> courses)
        {
            Students = students;
            Courses = courses;
        }
        public School()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
        public bool AddCourse(Course course)
        {
            if (Courses.Contains(course))
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
        public bool AddStudent(Student student)
        {
            if (Students.Contains(student))
            {
                return false;
            }
            Students.Add(student);
            return true;

        }
        public bool DeleteStudent(Student student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
                return true;

            }

            return false;

        }
        public bool AddStudentInCourse(Student student, Course course)
        {
            if (Students.Contains(student))
            {
                student.AddCourse(course);
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Names of students : {String.Join(", ", Students)} , Names of Courses {String.Join(", ", Courses)}";
        }
    }
}