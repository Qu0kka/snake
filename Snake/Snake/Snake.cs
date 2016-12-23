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
    }
}
