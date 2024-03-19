


namespace GSPITestTasks.Tasks
{
    /// <summary>
    /// В массиве содержатся все числа от 1 до 100, причем одно из них встречается дважды. Напишите метод, 
    /// принимающий указанный массив, который вернет дублирующийся элемент.
    /// </summary>
    internal class Task1
    {
        public int[] originalArray;

        public Task1()
        {
            originalArray = InitArray();
        }

        public int GetFirstDuplicateItem()
        {
            var arrGroup = iput.GroupBy(x => x).Where(y => y.Count() > 1);

            return arrGroup.First().First();
        }

        /// <summary>
        /// Предоставленный метод для задачи.
        /// </summary>
        /// <returns></returns>
        private static int[] InitArray()
        {
            int[] arr = new int[101];
            int minNumber = 1;
            int maxNumber = 100;

            for (int number = minNumber, pos = 0; number <= maxNumber; number++, pos++)
            {
                arr[pos] = number;
            }

            Random random = new Random();

            int randomNumber = random.Next(minNumber, maxNumber + 1);
            int randomPos = random.Next(0, maxNumber + 1);

            //Console.WriteLine("Random number is " + randomNumber);

            arr[100] = arr[randomPos];
            arr[randomPos] = randomNumber;

            return arr;
        }
    }
}
