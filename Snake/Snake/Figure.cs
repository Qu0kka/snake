using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Drow() // Виртуальный (переопределяемый) метод
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        // Метод обрабатывающий столкновение змейки с фигурой
        internal bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        // Метод обрабатывающий столкновение точек
        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
