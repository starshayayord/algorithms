using System.Linq;

namespace Part4
{
    public class Farmer
    {
        //Найти максимальные квадраты, которые заполнят все поле
        //Приравнять квадраты к меньшей стороне
        //Повторять для остатка, пока одна сторона не начнет делиться нацело на другую
        public int CrossField(int width, int height)
        {
            if (height == 0 || width == 0) return 0;
            //sides[0] - меньшая, sides[1] - большая сторона
            var sides = height > width ? new[] {width, height} : new[] {height, width};

            if (sides[1] % sides[0] == 0)
            {
                return sides[0];
            }

            var squareCount = sides[1] / sides[0];
            return CrossField(sides[1] - squareCount * sides[0], sides[0]);
        }
    }
}
