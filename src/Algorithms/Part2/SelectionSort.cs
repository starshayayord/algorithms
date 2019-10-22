using System;
using System.Collections.Generic;
using System.Linq;

namespace Part2
{
    //Сортировка выбором
    //Выбираем минимальный элемент из коллекции
    //Вставляем его в новую (отсортированную коллекцию), удаляя из неотсортированной.
    //Повторять, пока в неотсортированной коллекции есть элементы (== столько раз сколько элементов было в исходной последовательности)

    public class SelectionSort<T> where T : IComparable<T>
    {
        public static IEnumerable<T> Sort(IEnumerable<T> source)
        {
            if (source == null) yield break;
            var sourceList = source.ToList();
            while (sourceList.Count > 0)
            {
                var min = PopMinList(sourceList);
                yield return min;
            }
        }

        private static T PopMinList(List<T> list)
        {
            var min = list.First();
            foreach (var e in list.Where(e => min.CompareTo(e) > 0))
            {
                min = e;
            }

            list.Remove(min);
            return min;
        }
    }
}
