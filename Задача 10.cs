//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string DigitNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра введенного числа: " + DigitNumber [1]);