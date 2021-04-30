using System;

namespace Task7_6th
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] random = Random();
            BullsCows(random, 1);
            Console.ReadKey();
        }

        static int[] Random()
        {

            int autoNum1 = 0;
            int autoNum2 = 0;
            int autoNum3 = 0;
            int autoNum4 = 0;

            bool changer = false;
            while (changer == false)
            {
                Random anyNumber = new Random();

                autoNum1 = anyNumber.Next(0, 9);
                autoNum2 = anyNumber.Next(0, 9);
                autoNum3 = anyNumber.Next(0, 9);
                autoNum4 = anyNumber.Next(0, 9);
                if (autoNum1 == autoNum2 || autoNum1 == autoNum3 || autoNum1 == autoNum4 || autoNum2 == autoNum3 || autoNum3 == autoNum4 || autoNum3 == autoNum4)
                {
                    changer = false;
                }
                else
                {
                    changer = true;
                }
            }
            int[] random2 = new int[4] { autoNum1, autoNum2, autoNum3, autoNum4 };
            return random2;
        }

        static int AddNum(int n)
        {
            Console.WriteLine($"Введите цифру {n}");
            bool changer2 = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 0 && num <= 9)
                    {
                        changer2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы указали не корректные символы, Попробуйте ещё раз");
                    }
                }
                catch
                {
                    Console.WriteLine("Вы указали не корректные символы, Попробуйте ещё раз");
                }
            }
            while (changer2 == false);
            return num;
        }

        static void BullsCows(int[] random, int check)
        {
            int bulls = 0;
            int cows = 0;
            Console.WriteLine("Угадайте 4 цифры");
            int userNum1 = AddNum(1);
            int userNum2 = AddNum(2);
            int userNum3 = AddNum(3);
            int userNum4 = AddNum(4);
            int[] userNumber = new int[4] { userNum1, userNum2, userNum3, userNum4 };
            for (int i = 0; i < random.Length; i++)
            {
                for (int j = 0; j < userNumber.Length; j++)
                {

                    if (userNumber[i] == random[i])
                    {
                        cows++;
                        break;
                    }
                    else if (userNumber[j] == random[i])
                    {
                        bulls++;
                        break;
                    }
                }

            }
            if (cows == 4)
            {
                Console.WriteLine($"Вы отгадали все правильно. Попытки, которые Вам понадобились:{check}");
            }
            else
            {
                Console.WriteLine($"Коровы: {cows}, Быки: {bulls}. Попытка номер {check}.");
                BullsCows(random, ++check);

            }
        }

    }
}
