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
            Point p1 = new Point(4, 5, '#');
            p1.Draw();

            Point p2 = new Point(1, 3, '$');
            p2.Draw();

            Point p3 = new Point(5, 3, '*');
            Point p4 = new Point(7, 0, '%');

            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(7);
            numList.Add(10);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList) // Цикл выводит i-тые элементы списка
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); //Удалить 0-ой элемент списка

            List<Point> pList = new List<Point>(); //Список точек
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> charList = new List<char>(); //Список символов
            charList.Add('#');
            charList.Add('$');
            charList.Add('%');
            charList.Add('*');

            Console.ReadLine();
        }

    }
}
