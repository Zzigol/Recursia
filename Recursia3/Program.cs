using System;


namespace Recursia
{
    // 3. Найти сумму цифр числа с помощью рекурсии.

    class program
    {

        static void Recursia(int number, int numeral,ref int sum, int lastPart)
        {
           
            if (lastPart / 10 >= 0)
            {
                numeral = lastPart % 10;
                lastPart = lastPart / 10;
                sum += numeral;
                
                if (lastPart == 0) return;
                Recursia(number, numeral, ref sum, lastPart);
            }
        }

        static void Main()
        {
            //int number = 819;
            Console.WriteLine("Введите целое число для сложения цифр");
            int number = int.Parse(Console.ReadLine());
            int numeral = 0;
            int sum = 0;
            int lastPart=number;
            /*
            while (lastPart / 10 >= 0)
            {
                numeral = lastPart % 10;
                lastPart = lastPart / 10;
                sum+=numeral;
                if (lastPart == 0) break;
            }
            Console.WriteLine("число для сложения "+ numeral);
            Console.WriteLine("остаток для разбора "+ lastPart);
            Console.WriteLine("сумма " + sum);*/

            Recursia(number, numeral, ref sum, lastPart);
            Console.WriteLine("сумма = " + sum);

        }
    }
}