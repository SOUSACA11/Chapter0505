using System;

namespace Break_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            
            while (a)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                {
                    a = false;
                    }
               
                }
            }
        }
    }

//while문은 조건이 false이거나 while문 실행