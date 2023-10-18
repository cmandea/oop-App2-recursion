namespace ArrayHelperLibrary
{
    static class ArrayHelper
    {
        //Min si Max cu recursivitate
        //Definiti o clasa statica denumita ArrayHelper care implementeaza metode de calcul pentru minimul si maximul dintr-un vector.
        //Folositi recursivitate pentru implementare
        public static void PrintArray(string label, int[] array)
        {
            string commaSeparatedElements = string.Join(", ", array ?? new int[0]);
            Console.Write(label ?? "Array=");
            Console.WriteLine($"[{commaSeparatedElements}]");

        }

        public static int ReadNumber(string label, int maxTries, int defaultValue)
        {
            int tries = 0;
            do
            {
                Console.Write(label ?? "Number=");
                string text = Console.ReadLine();

                if (int.TryParse(text, out int result))
                {
                    return result;
                }

                Console.WriteLine($"'{text}' is not a valid numeric value, please try again...");

                tries++;

            }
            while (tries < maxTries);
            return defaultValue;
        }

        public static int max(int a, int b)
        {
            return (a > b ? a : b);
        }
        public static int min(int a, int b)
        {
            return (a < b ? a : b);
        }



        public static int readMinArray(int[] array, int i, int minVal)
        {

            if (i + 1 < array.Length)
            {
                return readMinArray(array, i + 1, min(array[i], minVal));

            }
            return minVal = min(array[i], minVal);

        }

        public static int readMaxArray(int[] array, int i, int maxVal)
        {

            if (i + 1 < array.Length)
            {
                readMaxArray(array, i + 1, max(array[i], maxVal));

            }
            return maxVal = max(array[i], maxVal);

        }
    }
}