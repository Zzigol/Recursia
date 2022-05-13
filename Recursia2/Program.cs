using System;


namespace Recursia
{

   
    // 2. Найти сумму элементов массива с помощью рекурсии.
   

    class program
    {

        static int Recursia(int[] myArray,ref int sum, int i)
        {
            if (i <= myArray.Length - 1)
            {
                sum += myArray[i];
                i++;
                Recursia(myArray,ref sum, i);
                
            }
          return sum;
        }

        static void Main()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int sum = 0;
            int i = 0;
            Console.WriteLine(Recursia(myArray,ref sum, i));

        }
    }
}
