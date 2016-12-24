﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Фиксированный размер окна
            Console.SetBufferSize(80, 25);

            // Рамочка
            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine Leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine Rightline = new VerticalLine(78, 0, 24, '+');
            Upline.Drow();            
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();


            // точки
            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();

            // Создаем еду
            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();

            // бесконечный цикл перемещения змейки, поедания и появления новой еды
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable) // Если была нажата какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // Читаем какая кнопка была нажата
                    snake.HandleKey(key.Key); // Обрабатываем нажатие клавии
                }
            }

           
        }

    }
}
