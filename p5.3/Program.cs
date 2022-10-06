internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите расстояние в см :"); // вывод на экран строки "..."
        int i = int.Parse(Console.ReadLine()); // ввод i
        Console.Write("Полных м: "); // вывод на экран строки "..."
        Console.WriteLine(i / 100); // вывод на экран строки "..."
    }
}