namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Print all nodes
            list.PrintList();

            // Remove a node
            list.Remove(10);
            list.PrintList();

            Console.WriteLine(list.Includes(5));
            Console.WriteLine(list.Includes(100)); 
        }
    }

}
