// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
using static System.Console;

Clear();

WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
string numberText = Convert.ToString(number);

if(numberText.Length > 2)
{
    WriteLine("Третья цифра -> " + numberText[2]);
}
else
{
    WriteLine("Третьей цифры нет");
}


