//MyFirstProject
using System;

int information1 = 5;
int information2 = 1;
int information3 = 3;

int Total = information1 + information2 + information3;
string[] Informations = {"First", "Second", "Third"};
foreach (string All in Informations)
{
    Console.WriteLine($"{Informations} : {Total}");
}

if (information1 < 6)
{
    Console.WriteLine("Information1 is the big value");
}
else if (information1 > 2)
{
    Console.WriteLine("Information1 is bigger 2");
}

if (information2 == 3)
{
    Console.WriteLine("This information = 3!");
}
else if (information2 >= 1)
{
    Console.WriteLine("information2 is bigger 1");
}

if (information3 <= 3)
{
    Console.WriteLine("information3 is smaller 3");
}
else if (information3 == 1)
{
    Console.WriteLine("information3 is 1 ");
}
