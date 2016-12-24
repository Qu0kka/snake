using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x1 ,int y1, char sym1)
        {
            x = x1;
            y = y1;
            sym = sym1;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int ofset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + ofset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - ofset;
            }
            else if (direction == Direction.UP)
            {
                y = y - ofset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + ofset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }


        // Проверка совпадения точки головы по координатам с точкой еды
        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y; // есть ли пересечения текущей точки (голова) с точкой, переданной в качестве аргумента (еда)
        }
    }

}
