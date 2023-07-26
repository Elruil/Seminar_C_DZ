//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите последовательно два числа");
Console.WriteLine("Введите первое число");
int numOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int numTwo = int.Parse(Console.ReadLine() ?? "");
if (numOne%numTwo == 0)
{
    Console.WriteLine($"число {numTwo} кратно числу {numOne}");
}
else 
{   int result = numOne%numTwo;
    Console.WriteLine($"Не кратно , остаток {result}");
}