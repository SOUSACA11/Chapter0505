using System;
namespace JINNY_ex4
{
    class fourth
    {
        static void Main(string[] args)
        {
            // 사용자 입력값만큼 별 반복 출력(정방향 별찍기형태로)
            // 경고문구 출력

            Console.Write("반복 횟수를 입력하세요 : ");
            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다");
            }

            for (int star = 0; star < count; star++)
            {
                for (int moon = 0; moon <= star; moon++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
