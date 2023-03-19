using System;

namespace JINNY_ex1
{
    class first
    {
        static void Main(string[] args)
        {
            // 이쁜 정방향 별찍기

            for (int star = 0; star< 5; star++)
            {
                for (int moon = 0; moon<=star; moon++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
