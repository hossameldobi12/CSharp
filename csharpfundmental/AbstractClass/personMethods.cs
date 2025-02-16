using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public  partial  class person
    {
       public person(string name, int age, string address)
        {
            Console.WriteLine("hello from person");
            Name = name;
            Age = age;
            Address = address;
        }
        public void print()
        {
            Console.WriteLine($"Age = {Age}");

        }
    }

    public struct mohsen
    {
        public string name { get; set; }
        public string job { get; set; }

        public int id { get; set; }


        public mohsen()
        {

        }

        public mohsen(string name, string job, int id)
        {
            this.name = name;
            this.job = job;
            this.id = id;
        }



    }
}
