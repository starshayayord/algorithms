using System.Collections.Generic;
using Part3.Models;

namespace Part3
{
    public class KeyInBoxFinder
    {
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
