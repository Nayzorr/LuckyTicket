using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                IsLucky();
            }

        }
        public static int EnterNum(string str, int minlenght, int maxlenght = int.MaxValue)
        {
            while (true)
            {
                Console.Write("\t" + str + ":");
                int value = 0;
                string s = Console.ReadLine().Trim();
                if (s.Length >= minlenght && s.Length <= maxlenght)
                {
                    if (int.TryParse(s, out value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели не число");
                    }
                }
                else
                {
                    Console.WriteLine("Количество цифр должно быть от {0} до {1}", minlenght, maxlenght);
                }
            }
        }
        public static void IsLucky()
        {
            int ticket = EnterNum("Введите билет", 4, 8);
            string s = ticket.ToString();
            int first_half_sum = 0;
            int last_half_sum = 0;

            if (s.Length % 2 != 0)
            {
                s = "0" + s;
            }
            for (int i = 0; i < s.Length / 2; i++)
            {
                first_half_sum += (int)Char.GetNumericValue(s[i]);
                last_half_sum += (int)Char.GetNumericValue(s[s.Length - 1 - i]);
            }
            Console.WriteLine(first_half_sum == last_half_sum ? "Билет счасливый" : "Билет НЕ счасливый");
        }
    }
}
