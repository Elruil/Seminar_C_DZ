// программа выводит случайное трехзначное число и
// удаляет вторую цифру этого числа
Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num/100;
int a2 = num%10;
//string b1 = $"{a1}";
//string b2 = $"{a2}";
//string c3 = b1 + b2;
//int result = int.Parse(c3);
//Console.WriteLine($"Случайное число {num}  с удаленной второй цифрой числа это {c3}  ");
int result = a1*10 + a2;
Console.WriteLine($"{num}  {result}");