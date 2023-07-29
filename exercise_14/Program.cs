//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");
int a = 7;
int b = 23;
if (num % a == 0)
{
    if (num % b == 0)
    {
        Console.WriteLine($"Число {num} кратно и 7 и 23  ");
    }
    else
    {
        Console.WriteLine($"Число {num} не кратно 23");
    }

}
else
{
    Console.WriteLine($"Число {num} не является кратно 7");
}