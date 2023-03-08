// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру

string a = Console.ReadLine()!; // Можно сравнивать строку без преобразования

if(a == "1") Console.WriteLine("It's Sunday");
else if(a == "2") Console.WriteLine("It's Monday");
else if(a == "3") Console.WriteLine("It's Tuesday");
else if(a == "4") Console.WriteLine("It's Wednesday");
else if(a == "5") Console.WriteLine("It's Thursday");
else if(a == "6") Console.WriteLine("It's Friday");
else if(a == "7") Console.WriteLine("It's Saturday");
else Console.WriteLine("There is no such day in the week");