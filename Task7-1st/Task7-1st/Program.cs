using System;

namespace Task7_1st
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            EnterNum(out int num);
            Console.WriteLine($"Укажите, степень числа {num}");
            EnterPow (out int pow);
            int result = Sum(num, pow);
            Console.WriteLine($"Сумма чисел равен  {result}");
        }

        static int Sum(int num, int pow)
        {
            if (pow == 2)
            {
                return num = num * num;
            }

            {
                return num * num + (num * Sum(num, --pow));
            }
        }

        static void EnterNum(out int num)
        {
            num = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
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

        static void EnterPow(out int pow)
        {
            pow = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    pow = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Введёный Вами номер не корректный, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
        }
    }
}
