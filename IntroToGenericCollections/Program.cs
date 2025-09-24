namespace IntroToGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array

            // PROS - type-safe
            // CONS - static in size

            int[] myArray = new int[4];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;
            myArray[3] = 40;

            //myArray[3] = "hello";
            //myArray[4] = 50;

            int sum = 0;

            for (int i=0; i<myArray.Length; i++)
            {
                int num = myArray[i];
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);
        }



    }
}
