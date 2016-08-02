using System;

public class SortProblem
{
    public static void Main()
    {
        Sort();
    }
    
    public static int distin(int[] matrix, int i)
    {


        int distin_primary = 0;
        int distin_second = 0;
        int index_distin = i;
        

        while (distin_primary > 0)
        {
            distin_primary = matrix[i] - matrix[i + 1];
        }
 

        for (int j=i+1; j < matrix.Length; j++)
        {

            distin_second = matrix[j ] - matrix[i];            
            if (distin_second > distin_primary)
            {
                index_distin = j;
                distin_primary = distin_second;
            }                
        }
        
        return index_distin; 
    }



    public static void Sort()
    {
        {
            var a = new[]
            {
              10, 10, 5, 2, 2, 5, 6, 7, 8, 15, 4, 4, 4, 2, 3, 5, 5, 36, 32, 623, 7, 475, 7, 2, 2, 44, 5, 6, 7, 71, 2
};



            for (int i = 0; i < a.Length; i++)
            {
                int index = distin(a, i);
                Console.Write($"{index} ");
                int memory = a[i];
                a[i] = a[index];
                a[index] = memory;
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
