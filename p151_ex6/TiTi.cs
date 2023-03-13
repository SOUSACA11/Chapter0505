using System;

namespace p151_ex6
{
    class TiTi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년의 숫자만 입력하세요.(ex.2) : ");

            string input = Console.ReadLine();
            int cl = int.Parse(input);

            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85) : ");

            string inputt = Console.ReadLine();
            int sc = int.Parse(inputt);

           // string answer;
            if (cl == 4)
            {
                if (sc >= 70 && sc <100)
                {
                    Console.WriteLine($"입력하신 점수 {sc}는(은) 합격 입니다. ");
                }
                else if (sc <70 && sc <100)
                {
                    Console.WriteLine($"입력하신 점수 {sc}는(은) 불합격 입니다. ");
                }
                    
            }
            else
            {
                if (sc >=60 && sc <100)
                {
                    Console.WriteLine($"입력하신 점수 {sc}는(은) 합격 입니다. ");
                }
                else if (sc <60 && sc <100)
                {
                    Console.WriteLine($"입력하신 점수 {sc}는(은) 불합격 입니다. ");
                }
            }

            if (sc < 0 || sc > 100)
            {
                Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
            }

            // Console.WriteLine($"입력하신 점수 {sc}는(은) {answer}입니다. ");

        }
    }
}
