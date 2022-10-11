namespace TheLawsOfFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NumArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            double Avg = 0;
            int Min = 0;

            foreach (int i in NumArray)
            {
                Avg += i;

                if (Min > i)
                {
                    Min = i;
                }
            }

            Console.WriteLine($"The average of the array is {Avg / NumArray.Length} and the smallest number in the array is {Min}.");

        }
    }
}