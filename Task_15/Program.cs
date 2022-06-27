// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;
using static System.Console;

Clear();

WriteLine("Введите день недели (цифра)");
int day = Convert.ToInt32(ReadLine());

if((day == 0) || day >7)
{
    WriteLine("Некорректное число");
    return;
}

string result = day >= 1 & day <6
? "Нет, ИДИ РАБОТАЙ!!!"
: "Да, можешь расслабиться";

WriteLine(result);

