using System;

namespace Task7_4th
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите первое число");
            EnterNum1(out int num1);
            Console.WriteLine("Введите второе число");
            EnterNum2(out int num2);
            
            BiggerOne(ref num1, num2);

            int text = DiapSum(num1, num2);
            Console.WriteLine($"Сумма чисел внутри данного диапазона равен {text-num2}");
            Console.ReadKey();

        }

        static int DiapSum(int num1, int num2)
        {
            if (num1 == num2)
            {
                return 0;
            }
            else
            {
                return num2 + DiapSum(num1, num2 - 1);
            }
        }

        static void EnterNum1(out int num1)
        {
            num1 = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = true;
                }

                catch
                {
                    Console.Write("Введёный Вами номер не корректный, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
        }

        static void EnterNum2(out int num2)
        {
            num2 = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = true;
                }

                catch
                {
                    Console.Write("Введёный Вами номер не корректный, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
        }

        static string BiggerOne (ref int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("Первый номер не может быть больше второго");
            }
        }

    }
}
