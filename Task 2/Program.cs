﻿/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberStr = number.ToString();

if (number / 100 > 0) Console.WriteLine($"{number} -> {numberStr[2]}");
else Console.WriteLine("Третьей цифры нет");
