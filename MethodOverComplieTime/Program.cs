using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverComplieTime
{
    public class Program
    {
        public void Sum(int x, int y)// 1st Method
        {
            Console.WriteLine("1st method int x, int ");
        }
        public int Sum(int x, int y,int z)//No. of parameter is different as compare to fisrt Method
        {
            Console.WriteLine("2nd method int x, int y,int z "+y);
            return z;
        }
        public float Sum(int x, float y)//Types of parameter is different as compare to fisrt Method
        {
            Console.WriteLine("3rd method int x, float y "+x);
            return 55.52f;
        }
        public void Sum(float y, int x)//Order of parameter is different as compare to third Method
        {
            Console.WriteLine("4 th float y, int ");
        }
        public char Sum(int x)//No. of parameter
        {
            Console.WriteLine("5th method int x "+x);
            return 'c';
        }
        public void Sum(int x, float y,int z)//Types of patameter see second method
        {
            Console.WriteLine("6 th method int x, float y, int z "+y);
        }
        public void Sum(int x, int y, float z)//Types of patameter see second method
        {
            Console.WriteLine("7 th method int x, int y, float z");
        }
        public void newMethod()
        {
            Console.WriteLine("Heloo harsh here");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Sum(22, 21.4f, 5);
            Console.WriteLine("Next....");
            int s =(p1.Sum(22));
            Console.WriteLine("Ascii value is "+s);
            int a =Convert.ToInt32 (p1.Sum(1,22.7f));
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
