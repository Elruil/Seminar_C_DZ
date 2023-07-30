//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int num;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out num))
    if ((num / 100 > 0) && (num / 1000 == 0))
        break;  
        Console.WriteLine("Ошибка ввода!");
}

Console.WriteLine($"Вы ввели число {num}");
int numOne = num / 100;
int numTwo = (num / 10) % 10;
int numThree = num % 10;
Console.WriteLine($"Вы ввели число {num}, первая цифра - {numOne}, вторая цифра - {numTwo}, третья цифра - {numThree}");
