// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        PrintCubeTable(n);
    }

    static void PrintCubeTable(int n)
    {
        Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
        Console.WriteLine("Число\tКуб");
        for (int i = 1; i <= n; i++)
        {
            int cube = Cube(i);
            Console.WriteLine(i + "\t" + cube);
        }
    }

    static int Cube(int number)
    {
        return number * number * number;
    }
}