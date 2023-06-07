using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07062023
{
    //наследование 
    internal class human 
    {
        int _id; 
        protected string _name;
        protected string _Lastname;

    }
    class Employer : human
    {
        double _salary;
         public Employer(string Fname , string lname , double salary)
        {
            _salary = salary;
            _name = Fname;
            _Lastname = lname;
        }
        public void Print()
        {
            Console.WriteLine($"Employer ={_Lastname}{_name}." + $"Salary = {_salary}");
        }
    }
}
