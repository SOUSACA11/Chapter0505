using System;

namespace p151_ex4
{
    class NiNi
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요. :");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 3 == 0)
                // 3으로 나눴을때 딱 떨어지는 것 = 배수
            {
                Console.WriteLine($"입력하신 정수 {number} 은(는) 3의 배수 입니다");
            }

            else
            {
                Console.WriteLine($"입력하신 정수 {number} 은(는) 3의 배수가 아닙니다");
            }
        }
    }
}
