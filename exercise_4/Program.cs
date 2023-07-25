Console.WriteLine("Программа запросит у вас три отличных друг от друга и от нуля целых числа. Для их сравнения введите их последовательно после запроса от программы");
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите третье число");
int numberThree = int.Parse(Console.ReadLine() ?? "");
int max = numberOne;

if (numberTwo > max)
{
    max = numberTwo;
}
if (numberThree > max)
{
    max = numberThree;
}
Console.WriteLine($"Максимальным из трех введенных чисел является число {max}");
