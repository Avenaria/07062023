using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _07062023
{

    //отношений = !=
    class Vector
    {// бинарные
        public int x { get; set; }
        public int y { get; set; }  
        public Vector() { }
        public Vector(point begin, point end)
        {
            x= end.x-begin.x;
            y= end.y-begin.y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { x = v1.x + v2.x, y = v1.y + v2.y };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { x = v1.x - v2.x, y = v1.y - v2.y };
        }
        public static Vector operator *(Vector v, int n) {

            v.x *= n;
            v.y *= n;
            return v;
        }
        public override string ToString()
        {
            return $"Vector : x ={x}, Y ={y}";
        }
    }
    class point
    {
        public int x { get; set; }
        public int y { get; set; }
        //унарные
        public static point operator++ (point s)//инкримент 
        {
            s.x++;
            s.y++;
            return s;
        }
        public static point operator --(point s)//дикримент 
        {
            s.x--;
            s.y--;
            return s;
        }
        public static point operator -(point s)
        {
            return new point {  x = -s.x, y =- s.y };
        }
        //перегрузка эколс для комфортного перегрузки сравнения
        public override bool Equals(object obj)
        {
            return  this.ToString()==obj.ToString() ;//так как метод бинарный сравнение левое и правое, нес мотяр на один обьект 
        }
        public static bool operator ==(point s1, point s2)//бинарная перегрузка нужно переопределить !=
        { 

            return s1.Equals(s2) ;
        }
        public static bool operator !=(point s1, point s2)//бинарная перегрузка нужно переопределить ==
        
            {
                return s1.Equals(s2);
            }
        public static bool operator >(point p1, point p2)
        {
            return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) < Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        }
        public static bool operator <(point p1, point p2)
        {
            return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) > Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        }
        public override string ToString()
        {
            return $"point : x ={x}, Y ={y}";
        }
        // перегрузка thru  folse
         public static bool operator  true(point p)
        {
            return p.x !=0 || p.y !=0 ? true : false;
        }

        public static bool operator false(point p)
        {
            return p.x != 0 && p.y != 0 ? true : false;
        }

    }
     
    //класс наследник : базовый класс {}  наследование только от одного класса , но  возможно наследовать от любього количесва интерфейсов 

    internal class Program
    {
        //public  static тип возвращаемый operator  символ перегруженного оператора (параметры){реализация}






        static void Main(string[] args)
        {

            // перегрузки 
            //point point = new point {x=10, y =10 };
            //Console.WriteLine(point);
            //Console.WriteLine(point++);
            //Console.WriteLine(++point);
            //Console.WriteLine(--point);
            //Console.WriteLine(point--);
            //Console.WriteLine(point);

            //point p1= new point {  x=2, y=3 };
            //point p2= new point { x=3, y=4 };

            //Vector v1 = new Vector(p1, p2);
            //Vector v2 = new Vector { x = 2, y = 3 };

            //Console.WriteLine(v1 + " " + v2);
            //Console.WriteLine(v1 - v2);
            //Console.WriteLine(v1 +  v2);
            //Console.WriteLine(v1 + " " + v2);
            //int a =5, b =5;
            //a+= b;
            //Console.WriteLine(a);
            point point1 = new point { x = 10, y = 10 };
            point point2 = new point { x = 20, y = 25 };
            Console.WriteLine(point1 == point2);
            if (point1) Console.WriteLine(" No ziro");
            if (point2) Console.WriteLine("ziro ");

            
        }



        //public static bool ReferenceEquals() { }
        //public static bool Equals() { }// равенство ссылок но для значемых типов данных, есть перегружунны для сравнения поелй для
        
    }

}
