// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int today=Convert.ToInt32(Console.ReadLine());
if (today>0&&today<8)
    if(today==6||today==7)
    { Console.WriteLine("это выходной день");}
    else {Console.WriteLine("это будний день");}
else {Console.WriteLine("число должно быть от 1 до 7");}

