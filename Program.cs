﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Write("Напишите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());

// if(num > 99 & num < 999)
// {
//     Console.WriteLine($"{num/10%10}");
// }else{
//     Console.WriteLine("Число не трехкратное");
// }

//**************************************************************************************************************************

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.Write("Напишите число: ");
// int num = int.Parse(Console.ReadLine());

// if(num>99){
//     while(num>999){
//         num = num / 10;
//     }
//     Console.WriteLine(num%10);
// }else{
//     Console.WriteLine("третьей цифры нет");
// }


//Более быстрое решение
// string num2 = Console.ReadLine();
// if(int.Parse(num2)>99){
//     Console.WriteLine(num2[2]);
// }else{
//     Console.WriteLine("третьей цифры нет");
// }

//****************************************************************************************************************************

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Напишите цифру дня недели: ");
// int num = int.Parse(Console.ReadLine());

// if(num<=7){
//     if(num>5){
//         Console.WriteLine($"{num} день недели выходной");
//     }else{
//         Console.WriteLine($"{num} день недели не выходной");
//     }

// }else{
//     Console.WriteLine("В неделе всего 7 дней");
// }