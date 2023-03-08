// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string na = Console.ReadLine()!;
string nb = Console.ReadLine()!;

int a = int.Parse(na);
int b = int.Parse(nb);
int max = a;

if(a > b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else if(a < b) 
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else Console.WriteLine("These numbers are equal");

