using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Mangment_System
{
    internal class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public Course(string name, string instructor)
        {
            Name = name;
            Instructor = instructor;
        }
        public override string ToString()
        {

            return $"Name {Name} , Instructor {Instructor}";
        }


    }
}