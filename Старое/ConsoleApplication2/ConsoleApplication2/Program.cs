using System;

public class SortProblem
{
    public static void Main()
    {
        Sort();
    }

    


    public static void Sort()
    {
        {
            var a = new[]
            {
              10, 10, 5, 2, 2, 5, 6, 7, 8, 15, 4, 4, 4, 2, 3, 5, 5, 36, 32, 623, 7, 475, 7, 2, 2, 44, 5, 6, 7, 71, 2
};


            /*
            for (int i = 0; i < a.Length; i++)
            {
                int max = a[i];
                if()
                int index = distin(a, i);
                Console.Write($"{index} ");
                int memory = a[i];
                a[i] = a[index];
                a[index] = memory;
            }*/
            for (int j = 0; j < a.Length; j++)
            {
                int max = a[j];
                int index = j;
                for (int i = 1+j; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        index = i;
                    }
                }
                int memory = a[j];
                a[j] = a[index];
                a[index] = memory;
                Console.Write( " " + index);
            }

            Console.WriteLine();


           for (int i = 0; i < a.Length; i++)
            {

                Console.Write($"{a[i]} ");
            }



            Console.ReadKey();
        }
    }
}
