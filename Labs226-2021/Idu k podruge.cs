﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи значение суммы для которой мы будем подбирать комбинацию цифр:");
            int s = int.Parse(Console.ReadLine());
            for (int k = 0; k < 10; k++)
                for (int y = k+1; y < 10; y++)
                    for (int x = y+1; x < 10; x++)
                        if (k + y + x == s && k != y && k != x && x != y)
                            Console.WriteLine($"Вот одна из вариаций, а ну-ка попробуй её:{k}{y}{x}");
        }
    }
}