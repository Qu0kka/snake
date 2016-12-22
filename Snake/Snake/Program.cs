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
            // Фиксированный размер окна
            Console.SetBufferSize(80, 25);

            // Рамочка
            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '*');
            VerticalLine Leftline = new VerticalLine(0, 0, 24, '*');
            VerticalLine Rightline = new VerticalLine(78, 0, 24, '*');
            Upline.Drow();            
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();


            // точки
            Point p1 = new Point(4, 5, '#');
            p1.Draw();

            Point p2 = new Point(1, 3, '$');
            p2.Draw();

            

            Console.ReadLine();
        }

    }
}
