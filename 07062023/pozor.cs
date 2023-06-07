using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07062023
{
    internal class Human
    {
        protected string _name;
        protected string _Lastname;

        public Human (string n, string l)
        {
            _name = n;
            _Lastname =l;

        }
    }
    class bulder : Human
    {
        double _salary;
        int _age;
        public bulder( string n,string l, int a, double s):base (n,l)
        {
            
            _salary = s;
            
            _age= a;

        }
    }
    class Sailor : Human
    {
        int _insea;
        public Sailor(string n, string l, int i) : base(n, l)
        {
           
            
      
            _insea = i;

        }
        public void Print()
        {
            Console.WriteLine($"Моряк  ={_Lastname}{_name}." + $"Часов в море  = {_insea}");
        }
    }
    class Pilot : Human
    {
        int _time_to;
        public Pilot(string n, string l, int t): base(n, l)
        {
            
            _time_to = t;

        }
        public void Print()
        {
            Console.WriteLine($"Пилот   ={_Lastname}{_name}." + $"Часов налета   = {_time_to}");
        }
    }
}
