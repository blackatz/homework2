﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

 int ThreeHundred(int number)

 {
      if (number < 100)
          {
          Console.WriteLine("Третьей цифры нет");
          }
      else
          {
          while(number > 1000)
          {
          number = number/10;
          }
          }
      return number = number - number/10*10;
      }

int finish = ThreeHundred(number);
Console.WriteLine("Третья цифра: " + finish);

