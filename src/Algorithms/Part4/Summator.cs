using System;
using System.Collections.Generic;

namespace Part4
{
    public class Summator
    {
        // Сумма чисел в числе рекурсивно
        public int Sum(int x)
        {
            x = Math.Abs(x);
            var stack = new Stack<int>();
            while (x != 0)
            {
                stack.Push(x % 10);
                x /= 10;
            }

            var sum = 0;
            return stack.Count == 0
                ? sum
                : sum + stack.Pop() + Sum(stack, sum);
        }

        private int Sum(Stack<int> stack, int sum)
        {
            return stack.Count == 0
                ? sum
                : sum + stack.Pop() + Sum(stack, sum);
        }
    }
}
