using System;
/*
Вводятся три числа, считай их разными способами,
увеличь каждое на единицу и выведи в строчку через пробел.
 */


namespace ThreeOptionsReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b;
            bool z = int.TryParse(Console.ReadLine(), out b);
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", ++a, ++b, ++c);
            Console.ReadKey();
        }
    }
}
