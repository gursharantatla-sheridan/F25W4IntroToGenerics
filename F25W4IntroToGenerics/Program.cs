namespace F25W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            object o = i;   // boxing
            i = (int)o;     // unboxing


            //if (AreEqual("5.5", 5.5))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");


            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArr = { 'h', 'e', 'l', 'l', 'o' };

            PrintArray<int>(intArr);
            PrintArray<double>(doubleArr);
            PrintArray<char>(charArr);
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("\nNumber of items = " + array.Length);

            foreach (T i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // non-generic method
        static bool AreEqual(object v1, object v2)
        {
            return v1.Equals(v2);
        }

        // generic method
        static bool AreEqual<T>(T v1, T v2)
        {
            return v1.Equals(v2);
        }
    }
}
