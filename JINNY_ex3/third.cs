﻿using System;

namespace JINNY_ex3
{
    class third
    {
        static void Main(string[] args)
        {
            // 이쁜 정방향 별찍기 while문 

            int star = 0;
            while (star < 5)
            {
                int moon = 0;
                while (moon <= star)
                {
                    Console.Write("*");
                    moon++;
                }
                Console.WriteLine();
                ++star;
            }

        }
    }
}

