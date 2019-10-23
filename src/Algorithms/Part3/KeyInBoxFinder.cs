using System.Collections.Generic;
using Part3.Models;

namespace Part3
{
    //Найти ключ в коробках. В каждой из коробок может быть ключ, коробка, или ничего
    public class KeyInBoxFinder
    {
        //Поиск с помощью цикла:
        //    Пока куча не опустела, берем коробку из кучи.
        //    Если внутри ключ, то возвращаем имя коробки и выходим из цикла
        //    Если внутри коробка, то кладем ее в кучу
        public string FindKeyCycle(Box[] boxes)
        {
            var boxStack = new Stack<Box>(boxes);
            while (boxStack.Count > 0)
            {
                var box = boxStack.Pop();
                if (box.HasKey)
                {
                    return box.Name;
                }

                if (box.InnerBox != null)
                {
                    boxStack.Push(box.InnerBox);
                }
            }

            return null;
        }

        //Поиск с помощью рекурсии:
        //    Для каждой начальной коробки из кучи, пока куча не опустела
        //    Если в коробке есть ключ, то возвращаем имя коробки и выходим
        //    Если внутри коробки есть коробка, то ищем ключ или коробку во внутренней коробке
        public string FindKeyRecursive(Box[] boxes)
        {
            foreach (var box in boxes)
            {
                var boxName = LookForKey(box);
                if (boxName != null)
                {
                    return boxName;
                }
            }

            return null;
        }

        private static string LookForKey(Box box)
        {
            if (box.HasKey)
            {
                return box.Name;
            }

            if (box.InnerBox != null)
            {
                return LookForKey(box.InnerBox);
            }

            return null;
        }
    }
}
