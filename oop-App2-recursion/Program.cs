
using ArrayHelperLibrary;

namespace oop_App2_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ArrayHelper.ReadNumber("The size of array=", 3, 0);

            // int nrforOccurrance = ArrayHelper.ReadNumber("Please enter number for count of occurrance=", 3, 0);
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                int item;
                if (i == 0)
                {
                     item = ArrayHelper.ReadNumber($"Element[{i}]=", 3, 0);
                    array[i] = item;
                }

                 
                if (i>=1)
                {
                   item = ArrayHelper.ReadNumberOrdered($"Element[{i}]=", 3, 0, array[i-1],"ASC");
                    array[i] = item;
                }
                                       
            }
            int numberSearch = ArrayHelper.ReadNumber("The number whose index is searched=", 3, 0);
            ArrayHelperLibrary.ArrayHelper.PrintArray("Array=", array);
            Console.WriteLine("The number whose index is searched=" + numberSearch);
            Console.WriteLine($"Index of searched number {numberSearch} is " + classNumber.SearchNumberIndex(array, numberSearch,0));

           
           
        }

        
    }
}