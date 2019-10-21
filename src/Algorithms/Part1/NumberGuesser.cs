using System.Linq;
using Part1.Models;

namespace Part1
{
    //Бинарный поиск - на входе получаем(делаем) отсортированный массив, на выходе получаем позицию элемента
    //или -1, когда элемент не найден (+кол-во попыток для проверки верности реализации алгоритма)

    public class NumberGuesser
    {
        public GuesserResult GuessPosition(int[] array, int secretNumber)
        {
            var sortedArray = array.OrderBy(x => x).ToArray();
            var attempt = 0;
            var startIndex = 0;
            var endIndex = sortedArray.Length - 1;
            while (startIndex <= endIndex) //==, если угадаем на последней попытке
            {
                attempt++;
                var index = (endIndex + startIndex) / 2;
                //угадали
                if (sortedArray[index] == secretNumber)
                {
                    return new GuesserResult
                    {
                        IndexOf = index,
                        Attempts = attempt
                    };
                }

                //много, берём левую половину
                if (sortedArray[index] > secretNumber)
                {
                    endIndex = index - 1;
                }
                //мало, берём правую половину
                else
                {
                    startIndex = index + 1;
                }
            }

            return new GuesserResult
            {
                IndexOf = -1,
                Attempts = attempt
            };
        }
    }
}
