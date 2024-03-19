using GSPITestTasks.Tasks;



namespace GSPITestTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = Task2.CountNormalSubstrings(input);

            Console.WriteLine($"Исходная строка: {input}");
            Console.WriteLine($"Количество нормальных разбиений строки: {result}");
        }
    }
}