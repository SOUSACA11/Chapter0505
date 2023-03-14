using System;
namespace p151_ex2_2
{
    class NINi
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. :");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= 50)
            {
                Console.WriteLine($"입력하신 숫자 {number}는(은) 50이상의 수 입니다");
            }

            else
                Console.WriteLine($"입력하신 숫자 {number}는(은) 50미만의 수 입니다.");
        }
    }
}

// 입력하신 숫자{0}은(는){1}, number, number >= 50? "50이상의 수" : "50미만의 수");
// Console.WriteLine ( number >= 50 ? "입력하신 숫자 {number}는(은) 50이상의 수 입니다" : "입력하신 숫자 {number}는(은) 50미만의 수 입니다")