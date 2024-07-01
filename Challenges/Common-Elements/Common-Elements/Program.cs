namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[] { 5, 10, 15, 20 };
            int[] secondArr = new int[] { 10, 15, 25 };

            int[] nums = CommonElements(firstArr, secondArr);

            Console.WriteLine("CommonElements:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] CommonElements(int[] firstArr, int[] secondArr)
        {
            List<int> commonElementsArray = new List<int>();

            foreach (var item in firstArr)
            {
                foreach (var item1 in secondArr)
                {
                    if (item == item1)
                    {
                        commonElementsArray.Add(item1);
                    }
                }
            }

            return commonElementsArray.ToArray();
        }
    }
}
