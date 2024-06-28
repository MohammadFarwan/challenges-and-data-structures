namespace Find_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 1, 2, 3 };
            int[] input2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] input3 = { 5, 10, 16, 20, 10, 16 };

            Console.WriteLine("Output: " + string.Join(", ", FindDuplicates(input1))); 
            Console.WriteLine("Output: " + string.Join(", ", FindDuplicates(input2))); 
            Console.WriteLine("Output: " + string.Join(", ", FindDuplicates(input3)));
        }

        public static int[] FindDuplicates(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            List<int> duplicates = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (counts.ContainsKey(array[i]))
                {
                    counts[array[i]]++;
                }
                else
                {
                    counts[array[i]] = 1;
                }
            }

            foreach (var item in counts)
            {
                if (item.Value > 1)
                {
                    duplicates.Add(item.Key);
                }
            }

            return duplicates.ToArray();
        }
    }
}
