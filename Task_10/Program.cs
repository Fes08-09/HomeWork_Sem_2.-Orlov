// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


using System;
using static System.Console;

Clear();
WriteLine("Введите трехзначное число от 100 до 999");
int number = Convert.ToInt32(ReadLine());

string result = number >= 100 & number < 1000
? $"{number/10%10}"
: "Число не подходит под условие";

WriteLine(result);

