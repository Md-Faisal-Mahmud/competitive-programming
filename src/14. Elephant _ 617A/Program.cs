﻿int n = int.Parse(Console.ReadLine());

if (n < 5)
{
    Console.WriteLine(1);
}
else if (n % 5 == 0)
{
    Console.WriteLine(n / 5);
}
else
{
    Console.WriteLine((n / 5) + 1);
}