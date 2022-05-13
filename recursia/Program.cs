using System;


namespace Recursia
{

    // 1. Реализовать вывод массива с помощью рекурсии.
    // 2. Найти сумму элементов массива с помощью рекурсии.
    // 3. Найти сумму цифр числа с помощью рекурсии.

    class program
    {

        static void Recursia (int[] myArray, int i)
        {
            if (i <= myArray.Length-1)
            {
                Console.WriteLine(myArray[i]);
                i++;
                Recursia(myArray, i);
            }
        }

        static void Main ()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};

            Recursia(myArray, 0);
            
        }
    }
}

