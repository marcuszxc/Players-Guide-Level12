namespace TheReplicatorOfDTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OrgArray = new int[5];
            int[] CopyArray = new int[5];

            for (int x = 0; x < OrgArray.Length; x++)
            {   
                Console.Write("Please enter a number: ");
                OrgArray[x] = int.Parse(Console.ReadLine());
            }

            for (int z = 0; z < CopyArray.Length; z++)
            {
                CopyArray[z] = OrgArray[z];
            }

            for(int y = 0; y < OrgArray.Length; y++)
            {
                Console.WriteLine($"Original array: {OrgArray[y]} Copied array: {CopyArray[y]}");
            }

        }
    }
}