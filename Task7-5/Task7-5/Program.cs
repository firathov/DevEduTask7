using System;

namespace Task7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер для выявления недели");
            EnterNum(out int num);
            Days text = (Days)num;

            Console.WriteLine($"Ваш день недели {text}");
            Console.ReadKey();
        }

        enum Days
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресение
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
                    if (num > 0 && num <= 7)
                    {
                        result = true;
                    }
                    else
                    {
                        Console.WriteLine("Введёный Вами номер не корректный, попробуйте ещё:\t");
                        result = false;
                    }
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
