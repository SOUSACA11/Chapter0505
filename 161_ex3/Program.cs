using System;

namespace _161_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요? : ");

            string input = Console.ReadLine();
            int month = int.Parse(input); // 형변환 불필요 없애도 됨
            // int month = 0;

            switch (month)
            {
                case 1: // case"1": case"3": case"5": case"7": case"8": case"10": case"12":
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"{month}월은 31일까지 있습니다."); // month = 31;
                    break;

                case 4: // case"4": case"6": case"9": case"11":
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"{month}월은 30일까지 있습니다."); // month = 30;
                    break;

                case 2:
                    Console.WriteLine($"{month}월은 28일까지 있습니다."); // month = 28;
                    break;

                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                    break; //return; / 스코프 끝
            }

            // Console.WriteLine($"{input}월은 {month}일까지 있습니다."); / defauit 외에 다 표출
        }
    }
}