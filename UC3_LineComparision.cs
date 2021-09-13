using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class UC3_LineComparision
    {
        public static void Compare()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double x3;
            double y3;
            double x4;
            double y4;
            double Length1;
            double Length2;

            //geting values from user
            Console.WriteLine("enter value of x1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of x3:");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of y3:");
            y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of x4:");
            x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter value of y4:");
            y4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Co-ordinates of Line1" + (+x1, +y1) + (+x2, +y2));
            Console.WriteLine("Co-ordinates of Line2" + (+x3, +y3) + (+x4, +y4));

            //calculating Length of lines using cartesian system method
            // formula: Length of line =sqrt(x2-x1)^2+(y2-y1)^2
            Length1 = Math.Sqrt((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2));
            Length2 = Math.Sqrt((x3 - x4) * (x3 - x4)) + ((y3 - y4) * (y3 - y4));
            Console.WriteLine("Length1:" + Length1 + "Length2:" + Length2);

            //using java compareto method
            if (Length1 > Length2)
            {
                Console.WriteLine("line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("line 2 is greater than line1");
            }
        }
    }
}
