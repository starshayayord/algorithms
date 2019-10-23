namespace Part3
{
    public class Factorial
    {
        //Рекурсивная функция вычисления факториала
        //(опущены случаи невалидных аргументов и переполнения)
        public long Calculate(long x)
        {
            if (x == 1)
            {
                return 1;
            }

            return x * Calculate(x - 1);
        }
    }
}
