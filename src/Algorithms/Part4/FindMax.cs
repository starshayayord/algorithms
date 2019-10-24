using System;
using System.Collections.Generic;
using System.Linq;

namespace Part4
{
    //Рекурсивно, с использованием базового случая, когда в списке 2 элемента, найти максимальный
    //Случай, когда массив пуст, опускаем
    public class FindMax
    {
        public int Find(List<int> list)
        {
            return list.Count == 1
                ? list.First()
                : Math.Max(list.First(), list.Count == 2 ? list.Last() : Find(list.Skip(1).ToList()));
        }
    }
}
