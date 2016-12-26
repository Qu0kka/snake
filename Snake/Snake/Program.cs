using System;
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

            // Создаем стены
            Walls walls = new Walls(80, 25);
            walls.Draw();

             // Создаем змейку
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
                // Обработчтк события столкновения змейки со стеной или своим хвостом
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

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
