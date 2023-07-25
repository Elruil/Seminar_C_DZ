Console.WriteLine("Программа для определения четности и вывода массива четных чисел от единицы до введенного вами числа.З47апросит число отличное от нуля. Введите его");
Console.WriteLine("Введите  число");
int number = int.Parse(Console.ReadLine() ?? "");
 Console.Write($"Массив четных чисел от единицы до числа {number} это : ");
for ( int i = 1; i <= number; ++i)
{
    if(i%2 == 0)
    Console.Write($" {i}");
 }
 