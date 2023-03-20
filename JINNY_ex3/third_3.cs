using System;

namespace JINNY_ex3
{
    class third_3
    {
        static void Main(string[] args)
        {
            // 이쁜 정방향 별찍기 do while문 

            int star = 0;

            do
            {
                int moon = 0;

                while (moon <= star)
                {
                    Console.Write("*");
                    moon++;
                }
                Console.WriteLine();
                star++;
            }
            while (star <5);
        }
    }
}