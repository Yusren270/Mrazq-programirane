using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    public class Display
    {
        public void Show(double p1, double p2, double p3, double p4, double p5)
        {
            Console.WriteLine(p1.ToString("F2")+"%");
            Console.WriteLine(p2.ToString("F2")+"%");
            Console.WriteLine(p3.ToString("F2")+"%");
            Console.WriteLine(p4.ToString("F2")+"%");
            Console.WriteLine(p5.ToString("F2")+"%");
        }
    }
}
