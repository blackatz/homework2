// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int number) 
{
    return number = (number - number/100*100 - number%10) / 10;
}

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(SecondNumber(number));