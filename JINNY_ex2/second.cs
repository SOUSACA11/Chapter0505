using System;

namespace JINNY_ex2
{
    class second
    {
        static void Main(string[] args)
        {
            // 이쁜 역방향 별찍기

            for (int star=0; star<5; star++)
            {
                for (int moon=5; moon>star; moon--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
