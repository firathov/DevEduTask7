using System;

namespace Task7_3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажме любое число");
            EnterNum(out int firstNum);
            Console.WriteLine("Укажите степень ранее указанного числа");
            EnterPaw(out int secondNum);
            Console.WriteLine($"Число {firstNum} в степени {secondNum} равен {Square(firstNum,secondNum)}");
            Console.ReadKey();
        }
        static int Square (int firstNum, int secondNum)
        {
            if (secondNum==1)
            {
                return firstNum;
            }
            else if (secondNum==0)
            {
                return firstNum = 1;
            }
            else
            {
                return firstNum * Square(firstNum, --secondNum);
            }
        }

        static void EnterNum(out int firstNum)
        {
            firstNum = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    firstNum = Convert.ToInt32(Console.ReadLine());
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
        static void EnterPaw(out int secondNum)
        {
            secondNum = Convert.ToInt32(null);
            bool result = false;
            do
            {
                try
                {
                    secondNum = Convert.ToInt32(Console.ReadLine());
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
