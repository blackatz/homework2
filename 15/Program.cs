﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine()!);

 if (Day(number))
     {
         Console.WriteLine("Да");
     }
 else
     {
         Console.WriteLine("Нет");
     }

bool Day(int number)
{
    return number == 6 || number == 7;
}

Day(number);