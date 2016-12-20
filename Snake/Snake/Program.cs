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
            int y = 2;
            char sym = '*';

            Draw(x, y, sym);

            int x1 = 3;
            int y1 = 5;
            char sym1 = '&';

            Draw(x1, y1, sym1);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
