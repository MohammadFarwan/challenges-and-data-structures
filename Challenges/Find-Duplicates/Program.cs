using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {16, 8, 31, 17, 15, 23, 17, 8};

            int[] duplicates = FindDuplicates(nums);

            Console.WriteLine("Duplicates:");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }


        public static int[] FindDuplicates(int[] numsArr)
        {
            List<int> duplicatesList = new List<int>();
            foreach (var item in numsArr)
            {
                int count = CountOfnum(item, numsArr);
                if (count > 1 && !duplicatesList.Contains(item))
                {
                    duplicatesList.Add(item);
                }
            }
            return duplicatesList.ToArray();
        }

        public static int CountOfnum(int num, int[] numsArr)
        {
            int count = 0;
            foreach (var item in numsArr)
            {
                if (num == item)
                {
                    count++;
                }
            }
            return count;   
        }
    }
}
