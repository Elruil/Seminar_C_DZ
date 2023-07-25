Console.WriteLine("Программа запросит у вас два целых числа. Для их сравнения введите их последовательно после запроса от программы");
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine() ?? "");
if (numberOne > numberTwo)
{
    Console.WriteLine($"Число {numberOne} больше числа {numberTwo}");
}
else if (numberOne < numberTwo)
{
    Console.WriteLine($"Число {numberTwo} больше числа {numberOne}");
}
else if (numberOne == numberTwo)
{
    Console.WriteLine($"Число {numberTwo} равно числу {numberOne}");
}