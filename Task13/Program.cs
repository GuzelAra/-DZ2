// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int number=Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number<100)
    {Console.WriteLine("третьей цифры не сущ");}
if (number>99&&number<1000)
    {Console.WriteLine($"{number%10}");}
if (number>999)
    {while (number>999)
    { number=number/10;}
    Console.WriteLine($"{number%10}");}


