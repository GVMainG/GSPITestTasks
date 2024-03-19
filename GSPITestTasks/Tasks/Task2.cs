


namespace GSPITestTasks.Tasks
{
    /// <summary>
    /// Две подстроки называются нормальным разбиений строки, если:
    /// 1. Эти две подстроки при конкатенации дают изначальную строку
    /// 2. Количество уникальных символов в подстроках одинаково
    /// Напишите метод, который принимает на вход строку и возвращает число равное количеству нормальных разбиений Пример: 
    /// Изначальная строка aacaba
    /// a – acaba(1 – 3)
    /// aa – caba(1 – 3)
    /// aac – aba(2 – 2) нормальное разбиение
    /// aaca – ba(2 – 2) нормальное разбиение
    /// aacab – a(3 – 1)
    /// Итого 2 нормальных разбиения В скобках указано количество уникальных символов в каждой подстроке
    /// </summary>
    internal static class Task2
    {
        /// <summary>
        /// Метод для тестового задания.
        /// </summary>
        /// <param name="input">Строка для разбиения.</param>
        /// <returns></returns>
        public static int CountNormalSubstrings(string input)
        {
            int count = 0;

            for (int i = 1; i < input.Length; i++)
            {
                string firstPart = input.Substring(0, i);
                string secondPart = input.Substring(i);

                int uniqueCharsFirst = firstPart.Distinct().Count();
                int uniqueCharsSecond = secondPart.Distinct().Count();

                if (uniqueCharsFirst == uniqueCharsSecond)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
