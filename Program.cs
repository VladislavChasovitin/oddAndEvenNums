using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumEvenNum = 0;
            int sumOddNum = 0;
            int evenNum = 0;

            int oddNum = 0;

            Console.WriteLine("Введите первое число диапазона:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число диапазона");
            int num2 = int.Parse(Console.ReadLine());



            while (num1 <= num2)
            {


                if (num1 % 2 == 0)
                {
                    evenNum++;
                    sumEvenNum += num1;

                }
                else
                {
                    oddNum++;
                    sumOddNum = sumOddNum + num1;
                }
                num1++;

            }


            Console.WriteLine($"Четных чисел: {evenNum}");
            Console.WriteLine($"Нечетных чисел: {oddNum}");
            Console.WriteLine($"Сумма чётных чисел {sumEvenNum}");
            Console.WriteLine($"Сумма нечётных чисел {sumOddNum}");

        }
      }
    }

