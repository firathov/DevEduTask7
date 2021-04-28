using System;

namespace Task7_2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите любое целое число");
            
            EnterNum1 (out int num1);
            Console.WriteLine("Укажите любое второе целое число");
            EnterNum2(out int num2);

            callBack(num1, num2);
            Console.ReadKey();
        }

        static int callBack(int num1, int num2)
        {
            if (num1 > num2)
            {
                num1 = num1 % num2;
            }
      
            else
            {

                num2 = num2 % num1;
            }



            if (num1 != 0 && num2 != 0)
            {
                return callBack(num1, num2); 
            }
            else
            {
               Console.Write($"Наибольший Общий Делитель равен {num1 + num2}");
                return num1+num2;
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
                if (num1 == 0)
                {
                    Console.WriteLine("Не корректный ввод, попробуйте ещё");
                    result = false;
                }
                else if (num1 < 0)
                {
                    num1 = num1 * (-1);
                }
            }
            while (result == false);
        }
        static void EnterNum2 (out int num2)
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
                if (num2 == 0)
                {
                    Console.WriteLine("Не корректный ввод, попробуйте ещё");
                    result = false;
                }
                else if (num2 < 0)
                {
                    num2 = num2 * (-1);
                }
            }
            while (result == false);
        }


    }
}