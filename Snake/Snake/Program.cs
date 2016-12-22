using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5, '#');
            p1.Draw();

            Point p2 = new Point(1, 3, '$');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(3,7,5,'^');
            line.Drow();

            VerticalLine line1 = new VerticalLine(5, 4, 8, '+');
            line1.Drov();

            Console.ReadLine();
        }

    }
}
