using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle arec = new rectangle();

            Console.WriteLine("width = {0}, height= {1}", arec.Width, arec.Height);
            arec.Width = 4;
            arec.Height = 5;
            Console.WriteLine("width = {0}, height= {1}", arec.Width, arec.Height);

            Console.ReadKey();

            square asqu = new square(8);

            Console.WriteLine("width = {0}, height= {1}", asqu.Width, asqu.Height);
            Console.WriteLine("area = {0}, circumference= {1}", asqu.area(), asqu.circumference());

            Console.ReadKey();
        }
    }
}
