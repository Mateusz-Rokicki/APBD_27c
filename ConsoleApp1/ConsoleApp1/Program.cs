// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;
using System.Threading.Channels;

Console.WriteLine("Hello, World!!!!");
Console.WriteLine("Hello, World!!!!");
int[] tab = { 1, 2, 3, 4, 5 };
Console.WriteLine(Average(tab));

static double Average(int[] num)
{
    double sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum += num[i];
    }

    return sum / num.Length;
}