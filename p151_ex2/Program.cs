using System;

namespace p151_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요. : ");
            //Write 한줄이 아니라 옆으로 표시되어야 하니깐 write
            //만약 WriteLine 이면 다음줄로 들어감
            //즉 "점수를 입력하세요. : " 하고 다음줄에서 사용자 입력값이 표출됨

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            //int number = int.Parse(input);

            if (number >= 90)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) A 학점 입니다");
                // ($"인력하신 점수" + $"{number}는(은) A 학점 입니다");
            }

            else if (number >= 80)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) B 학점 입니다");
            }

            else if (number >= 70)
            {
                Console.WriteLine($"입력하신 점수 {number}는(은) C 학점 입니다");
            }

            else
                Console.WriteLine($"입력하신 점수 {number}는(은) D 학점 입니다");
        }
    }
}


// string input = Console.ReadLine();
// int number = int.Parse(input);

// string grade;
// if (number >= 90)
// {
//    grade = "A";
//  }
// else if (number >= 80)
// {
//    grade = "B";
// }
// else if (number >= 70)
// {
//    grade = "C";
// }
// else
// {
//    grade = "F";
// }

// Console.WriteLine($"입력하신 점수 {number}는(은) " +
//    $"{grade} 학점 입니다.");