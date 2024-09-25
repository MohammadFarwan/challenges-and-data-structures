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

            // Add a node at First
            list.AddFirst(15);
            list.PrintList();

            // Remove a node
            list.Remove(10);
            list.PrintList();

            Console.WriteLine(list.Includes(5));
            Console.WriteLine(list.Includes(100));

            Console.WriteLine("---------------------------------------");


            LinkedList list2 = new LinkedList();
            list2.Add(5);
            list2.Add(20);
            list2.Add(20);
            list2.Add(10);
            list2.Add(5);
            list2.Add(10);

            // Print all nodes
            Console.WriteLine("Original list:");
            list2.PrintList();

            // Remove duplicates
            list2.RemoveDuplicate();
            Console.WriteLine("After removing duplicates:");
            list2.PrintList();


            Console.WriteLine("---------------------------------------");


          
            LinkedList listA = new LinkedList();
            listA.Add(1);
            listA.Add(3);
            listA.Add(5);

            LinkedList listB = new LinkedList();
            listB.Add(2);
            listB.Add(4);
            listB.Add(6);

            Console.WriteLine("List A:");
            listA.PrintList();

            Console.WriteLine("List B:");
            listB.PrintList();

            LinkedList mergedList = LinkedList.MergeSortedLists(listA, listB);

            Console.WriteLine("Merged List:");
            mergedList.PrintList();


            Console.WriteLine("---------------------------------------");


            LinkedList Rlist = new LinkedList();
            Rlist.Add(1);
            Rlist.Add(2);
            Rlist.Add(3);
            Rlist.Add(4);
            Rlist.Add(5);
            Rlist.Add(6);

            Console.WriteLine("Original List:");
            Rlist.PrintList();

            int k = 2;
            Rlist.RotateLeft(k);

            Console.WriteLine($"\nList after rotating left by {k}:");
            Rlist.PrintList();
        }

    }
}
