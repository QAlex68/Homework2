// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое положительное число: ");
string input = Console.ReadLine();
char [] array = input.ToCharArray();

if (array.Length < 3) Console.Write("Нет третьего числа!");
else
Console.Write($"Третья цифра числа {input}: " + array[2]);