/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("введите число" );
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("в числе " + num + " нет третьей цифры");
}
else if(num <= 999)
    {
        Console.Write("третья цифра заданного числа = "+ num % 10);
    }
else while (num >= 999)
{
    {
       num = num / 10;   
    }
       if (num <= 999)
    {
       Console.WriteLine("третьим числом из заданного является " + num % 10);
    } 
}
    


    





     
    






