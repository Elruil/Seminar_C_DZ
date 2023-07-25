Console.WriteLine("Программа для определения четности запросит у вас число отдичное от нуля. Введите его");
Console.WriteLine("Введите  число");
int number = int.Parse(Console.ReadLine() ?? "");
if (number%2 == 0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} нечетное");
}