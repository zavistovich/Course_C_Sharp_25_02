// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -3 -> yes
// a = -3, b = 9 -> no

// string s_a = Console.ReadLine()!;
// string s_b = Console.ReadLine()!;
// int a = int.Parse(s_a);
// int b = int.Parse(s_b);

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

// if(a == b * b) Console.WriteLine("a is a square b");
// else Console.WriteLine("a is not a square b");

if(a == b * b)
{
    Console.WriteLine("a is a square b");
}
else
{
    Console.WriteLine("a is not a square b");
}
