//Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int num;
while(true)
{
    Console.WriteLine("Введите  число");
    if (int.TryParse(Console.ReadLine() , out num))
    break;
    Console.WriteLine("Ошибка ввода");
}
if ( num > 99)
{
    int ThirdNum = GetThirdNumber(num);
    static int GetThirdNumber(int a)
    {
        while ( a > 999)
        a/= 10;
        int ThirdNum = a%10;
        return ThirdNum;
    }

    Console.WriteLine($"Введенное число {num}, третья цифра введенного числа {ThirdNum}");
}
else
Console.WriteLine($"У введенного число {num} нет третьей цифры");