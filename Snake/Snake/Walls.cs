using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        // Список фигур прпятстсий
        List<Figure> wallList;

        public Walls(int mapWith, int mapHight)
        {
            wallList = new List<Figure>();

            // Рамочка
            HorizontalLine Upline = new HorizontalLine(0, mapWith-2, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, mapWith-2, mapHight-1, '+');
            VerticalLine Leftline = new VerticalLine(0, 0, mapHight-1, '+');
            VerticalLine Rightline = new VerticalLine(mapWith-2, 0, mapHight-1, '+');

            wallList.Add(Upline);
            wallList.Add(Downline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);
        }

        // Метод Draw для отрисовки фигур
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Drow();
            }          
        }

        // Метод для обработки события столкновения змейки со стеной
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                    {
                       return true;
                     }
            }
            return false;
        }
    }
}
