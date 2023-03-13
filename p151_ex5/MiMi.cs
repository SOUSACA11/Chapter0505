using System;

namespace p151_ex5
{
    class MiMi
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번쨰 정수를 입력해 주세요. : ");

            string input = Console.ReadLine();
            int n1 = int.Parse(input);

            Console.Write("세 개의 정수 중 두번쨰 정수를 입력해 주세요. : ");

            string inputt = Console.ReadLine();
            int n2= int.Parse(inputt);

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. : ");

            string inputtt = Console.ReadLine();
            int n3 = int.Parse(inputtt);

            int max, min;
            if ( n1 >= n2)
            {
                max = n1;
                min = n2;
            }
            else
            {
                max = n2;
                min = n1;
            }

            if (n3 > max)
            {
                max = n3;
            }

            if (n3 < min)
            {
                min = n3;
            }

            int sum = n1 + n2 + n3;
            int avg = sum / 3;

            Console.WriteLine($"입력하신 {n1},{n2},{n3} 중 최대값은 {max}이며, 최솟값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {n1},{n2},{n3} 의 합은 {sum}이며, 평균은{avg} 입니다.");

        }
    }
}
