using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace OOPTaskLecture01
{
    enum Gender
    {
        male,
        female
    }
    enum securityPrivllage
    {
        guest,
        devolper,
        secretary,
        dba
    }
    internal class Empolyee
    {



        private int id;
        private string name;
        private securityPrivllage securtyLevel;
        private Gender gender;
        private double salary;
        private DateTime date;

        public double Salary { get;set; }
        public int ID
        {
            set
            {
                id = value;
            }
            get { return id; }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }
        public securityPrivllage SecurtyLevel
        {
            set
            {
                securtyLevel = value;
            }
            get { return securtyLevel; }
        }
        public Gender Gen
        {
            set
            {
                gender = value;
            }
            get { return gender; }
        }
        public string Datetime { get; set; }
        public Empolyee()
        {
            ID = default;
            Name = default;
            SecurtyLevel = default;
            Gen = default;
            Datetime = default;

        }
        public Empolyee(int id , string name, securityPrivllage securityLevel, Gender gender , double salary,string date)
        {
            ID = id;
            Name = name;
            SecurtyLevel = securityLevel;
            Gen = gender;
            Salary = salary;
            Datetime = date;
            
        }
        public override string ToString()
        {

            return string.Format("The id is {0},the name is {1} ,the gender is {2}, the security level is {3} , the salary is {4}, The Date is {5}", ID, Name, Gen, SecurtyLevel, Salary, Datetime );
        }


    }
}
