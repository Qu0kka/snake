﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }

        public override void Drow() // Переопределение метода Drow
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // желтй цвет для горизонтальнх линий
            base.Drow(); // Используется описание метода соответствующее базовому классу
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
