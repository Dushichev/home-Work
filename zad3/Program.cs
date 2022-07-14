/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("введите цифру,соответствующую дню недели от 1 до 7 ");
int number = int.Parse(Console.ReadLine());


if(number == 1)
{   
    Console.Write("понедельник , рабочий день");
}
if(number == 2)
{
    Console.Write("вторник , рабочий день");
}
if(number == 3)
{
    Console.Write("среда , рабочий день");
}
if(number == 4)
{
    Console.Write("четверг , рабочий день");
}
if(number == 5)
{
    Console.Write("пятница , рабочий день");
}
if(number == 6)
{
    Console.Write("суббота , выходной день");
}

if(number == 7)
{
    Console.Write("воскресенье , выходной день");
}

    