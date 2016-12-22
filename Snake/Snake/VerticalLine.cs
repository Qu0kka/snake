using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yup, int ydown, char sym)
        {
            pList = new List<Point>();
            for(int y = yup; y <=ydown; y++)
            {
                Point v = new Point(x, y, sym);
                pList.Add(v);
            }
        }

    }
}
