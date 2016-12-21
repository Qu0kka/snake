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
            int x = 1;
            Func1(x);                                   //В функции используется копия x
            Console.WriteLine("Call Funk1. x = " + x);


            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);


            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y); //Изменяются координаты самой точки p1 (p и p1 указывают на одну область памяти, где хранятся координаты и символ)

            Point p2 = new Point(4, 5, '#');
            p1 = p2;                          // p1 указывает на ту же область памяти что и p2
            p1.x = 7;
            p1.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y);

            Point p3 = new Point(2, 3, '&');
            Reset(p3);                      // p3 останется без изменений, поскольку в функции изменялась сама переменная p, содержащая адрес
            Console.WriteLine("Call Reset. p3.x = " + p3.x + ", p3.y = " + p3.y);

            Console.ReadLine();
        }
        public static void Func1(int value)
        {

        }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int x)
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Reset(Point p) //Пересоздание точки
        {
            p = new Point(1, 2,'$');
        }
    }
}
