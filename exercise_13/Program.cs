//Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int num1;
while(true)
{
    Console.WriteLine("Введите  число");
    if (int.TryParse(Console.ReadLine() , out num1))
    break;
    Console.WriteLine("Ошибка ввода");
}
int num = Math.Abs(num1);
if  (num > 99) 
{   
    int ThirdNum = GetThirdNumber(num);
    static int GetThirdNumber(int a)
    {   
        while ( a > 999)
        a/= 10;
        int ThirdNum = a%10;
        return ThirdNum;
    }

    Console.WriteLine($"Введенное число {num1}, третья цифра введенного числа {ThirdNum}");
}
else
Console.WriteLine($"У введенного число {num1} нет третьей цифры");