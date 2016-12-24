using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWith;
        int mapHight;
        char sym;

        Random random = new Random();

        // Задаем диапазон в котором будет помещена еда и символ еды
        public FoodCreator(int mapWith, int mapHight, char sym)
        {
            this.mapWith = mapWith;  // Глобальным переменным присваиваются значения локальных
            this.mapHight = mapHight;
            this.sym = sym;
        }

        // Выводим еду не экран
        public Point CreateFood()
        {
            int x = random.Next(2, mapWith - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, sym);
        }
    }
}
