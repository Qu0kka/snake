using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
               
        }

        internal void Move()
        {
            Point tail = pList.First(); // Берем первую точку списка (хвост)
            pList.Remove(tail); // Удаляем из списка точек хвост
            Point head = GetNextPoint(); // Метод возвращает точку (голову)
            pList.Add(head); // Добавляем глову в список
            tail.Clear(); // Заменяем хвостовую точку на пробел
            head.Draw(); // Рисуем голову
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last(); // Берем текущую (последнюю) точку змеи до перемещения - голову
            Point nextPoint = new Point(head); // Создаем копию точки головы
            nextPoint.Move(1, direction); // Сдвигаем точку-копию головы по направлению direction
            return nextPoint; // метод возвращает точку-новую голову
        }

        // метод поедания
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym; //символ еды становится символом змейки
                pList.Add(food); // Добавляем в список точку еды
                return true;
            }
            else
            {
                return false;
            }

        }

        // Метод, обрабатывающий столкновение  головы и хвоста змейки
        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++) // провера пересечения с любой точкой змейки, кроме головы
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)    // если нажата левая стрелка
                direction = Direction.LEFT;   // то переменная direction принимает значение LEFT
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
    }
}
