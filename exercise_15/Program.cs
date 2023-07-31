// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
int num;
while(true)
{
    Console.WriteLine("Введите  число обозначающе день недели от одного до семи");
    if (int.TryParse(Console.ReadLine() , out num))
    break;
    Console.WriteLine("Ошибка ввода");
}
if (num == 6)
Console.WriteLine($"Введенное число {num}, это суббота , а занчит выходной. ");
else if (num == 7)
Console.WriteLine($"Введенное число {num}, это воскресенье , а занчит выходной.");
else if ( num < 1 || num  > 7 )
Console.WriteLine($"Введенное число {num}, не входит в укаханный для введения диапазон");
else if (  num ==1 || num == 2 || num == 3 || num == 4 || num == 5)
Console.WriteLine($"Введенное число {num}, это буднний день ");
