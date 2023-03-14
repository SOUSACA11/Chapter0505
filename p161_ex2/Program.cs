using System;

namespace p161_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");

            Console.Write("첫 번째 정수를 입력해주세요. : ");

            string input = Console.ReadLine();
            int first = int.Parse(input);

            Console.Write("두 번째 정수를 입력해주세요. : ");

            string inputt = Console.ReadLine();
            int second = int.Parse(inputt);

            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% : ");

            string inputtt = Console.ReadLine();

            int value = 0;

            int a = first + second;
            int b = first - second;
            int c = first * second;
            int d = first / second;
            int e = first % second;

            switch (inputtt)
            {
                case "+":
                    Console.WriteLine($"입력하신 {first} + {second}의 결과값은 {a} 입니다.");
                    break;

                case "-":
                    value = first - second;
                    break;

                case "*":
                    value = first * second;
                    break;

                case "/":
                    value = first / second;
                    break;




                    Console.WriteLine($"입력하신 {first}{inputtt}{second}의 결과값은 {value} 입니다.")
            }
        }
    }
}
