using System.Collections.Generic;
using System.Linq;

namespace Part4
{
    //рекурсивная функция для подсчета элементов в списке
    public class RecursiveCount
    {
        public int Count(List<int> list)
        {
            var count = 0;
            return !list.Any() ? count : 1 + Count(list.Skip(1).ToList());
        }
    }
}
