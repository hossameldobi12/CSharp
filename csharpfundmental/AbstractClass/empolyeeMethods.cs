using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public partial class Empolyee
    {
        public Empolyee(string name, int age, string address, int emplyeeid, int salary) : base(name, age, address)
        {
            Console.WriteLine("hello from employee");
            Emplyeeid = emplyeeid;
            Salary = salary;
        }
        public void emplyeevalue()
        {

            Console.WriteLine($"salary = {Salary}");
        }

    }
}
