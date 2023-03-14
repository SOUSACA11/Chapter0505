using System;

namespace p151_ex6_2
{
    class TiTi2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");

            Console.Write("현재 본인의 학년을 숫자만 입력하세요. (ex.2) : ");
            string input = Console.ReadLine();
            int cl = int.Parse(input);

            Console.Write("현재 본인의 점수를 입력해 주세요. (ex.85) : ");
            string inputt = Console.ReadLine();
            int gr = int.Parse(inputt);
                      
            switch(cl)
            {
                case 4 when gr >= 70 && gr <100:
                    Console.WriteLine($"입력하신 점수{gr}는 합격입니다. ");
                    break;
                case 4 when gr < 70 && gr >0:
                    Console.WriteLine($"입력하신 점수{gr}는 불합격입니다.");
                    break;
                case 1 when gr >= 60 && gr < 100: case 2 when gr >= 60 && gr < 100: case 3 when gr >= 60 && gr <100:
                    Console.WriteLine($"입력하신 점수 {gr}는 합격입니다. ");
                    break;
                case 1 when gr < 60 && gr >0: case 2 when gr < 60 && gr >0: case 3 when gr < 60 && gr > 0:
                    Console.WriteLine($"입력하신 점수 {gr}는 불합격입니다. ");
                    break;

                default:
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
                    break;
            }
;
        }
    }
}
// P151_ex6 / TiTi / if 버전