﻿/*Задача 10: Напишите программу, которая принимает на
 вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomNumber(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int GetFirstLastNumber (int RandomNumber)
{
    int number2= (RandomNumber /10) % 10;
        return number2;
   }
int RandomNumber = GetRandomNumber(100, 999);
int number = GetFirstLastNumber(RandomNumber);
Console.WriteLine (RandomNumber);
Console.Write (number);
