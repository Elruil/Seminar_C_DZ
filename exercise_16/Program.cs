//Напишите программу, которая принимает на вход два числа и 
//проверяет, является ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите последовательно два числа");
Console.WriteLine("Ввелите первое число");
int numOne = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число");
int numTwo = int.Parse(Console.ReadLine() ?? "");
if (numOne / numTwo == numTwo)
{
    Console.WriteLine($"Число {numOne} является квадратом числа {numTwo} ");
}
else if (numTwo / numOne == numOne)
{
    Console.WriteLine($"Число {numTwo} является квадратом числа {numOne} ");
}
else
{
    Console.WriteLine($"Числa {numTwo} и {numOne} не являются квадратами друш друга");
}