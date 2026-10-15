using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    internal class HristogramActionController
    {
        Hristogram hristogram;
        Display display;
        public HristogramActionController()
        {
            int n = int.Parse(Console.ReadLine());
            hristogram = new Hristogram(n);
            display = new Display();
            for(int i = 0; i < n; i++)
            {
                hristogram.numbers[i] = int.Parse(Console.ReadLine());
            }
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            for(int i=0;i<n;i++)
            {
                int number = hristogram.numbers[i];
                if (number < 200)
                {
                    count1++;
                }
                else if (number <=399)
                {
                    count2++;
                }
                else if (number <=599)
                {
                    count3++;
                }
                else if (number <=799)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }
            }
            double p1 = (double)count1 / n * 100;
            double p2 = (double)count2 / n * 100;
            double p3 = (double)count3 / n * 100;
            double p4 = (double)count4 / n * 100;
            double p5 = (double)count5 / n * 100;
            display.Show(p1,p2,p3,p4,p5);
        }

    }
}
