using System;

namespace p151_ex5_2
{
    class MiMi2
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. : ");
            string input = Console.ReadLine();
            int A = int.Parse(input);

            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. : ");
            string input2 = Console.ReadLine();
            int B = int.Parse(input2);

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. : ");
            string input3 = Console.ReadLine();
            int C = int.Parse(input3);

            int max;
            int min;

         // switch (A - B)
         // {
         //   case 1: case 0: min = B;
         //       break;
         //  default: min = A;
         // }

            switch (A - B)
            {
                case 1:
                    max = A;
                    min = B;
                    break;
                case 0:
                    max = B;
                    min = A;
                    break;
            }

            switch (min-C)
            {
                case 1:
                    min = C;
                    break;
                case 0:
                    min = min;
                    break;
            }

            switch (max - C)
            {
                case 0:
                    max = C;
                    break;
                case 1:
                    max = max;
                    break;
            }
        }
    }
}
