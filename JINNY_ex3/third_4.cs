using System;

namespace JINNY_ex3
{
    class third_4
    {
        static void Main(string[] args)
        {
            // 이쁜 역방향 별찍기 do while문 

            int star = 5;

            do
            {
                int moon = 0;

                while (moon < star)
                {
                    Console.Write("8");
                    moon++;
                }
                Console.WriteLine();
                star--;
            }
            while (star > 0);
        }
    }
}