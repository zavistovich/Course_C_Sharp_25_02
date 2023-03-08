// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


string na = Console.ReadLine()!;
int a = int.Parse(na);

if(a % 2 == 0) Console.WriteLine("The number is even");
else Console.WriteLine("The number is not even");


