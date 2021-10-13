﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Tasks
    {
        public static void MaxSummOfDigits()
        {
            int N = int.Parse(Console.ReadLine());
            int maxSum = 0;
            int number = 0;
            for (int i = 1; i <= N; i++)
            {
                int buff = i;
                int summ = 0;
                while(buff > 0)
                {
                    summ += buff % 10;
                    buff = buff / 10;
                }
                if (maxSum < summ)
                {
                    maxSum = summ;
                    number = i;
                }


            }
            Console.Write(number);
            Console.WriteLine(" "+ maxSum);

        }

        public static void CountOfSeven()
        {
            int N = int.Parse(Console.ReadLine());
            int CountOfSeven = 0;
            for (int i = 1; i <= N; i++)
            {
                int buff = i;
                while(buff > 0)
                {
                    if(buff % 10 == 7)
                    {
                        CountOfSeven += 1;
                    }
                    buff = buff / 10;
                }
            }
            Console.WriteLine(CountOfSeven);
        }


    }
}
