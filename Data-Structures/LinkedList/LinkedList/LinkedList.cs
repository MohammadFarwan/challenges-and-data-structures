using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head { get; protected set; }

        public LinkedList()
        {
            head = null;
        }

        // Add a node to linked list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Add a node to First
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        // Check if the linked list contains a specified node
        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Remove node 
        public void Remove(int data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Print All nodes
        public void PrintList()
        {
            Node current = head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }



        // Remove duplicate nodes from the linked list
        public void RemoveDuplicate()
        {
            try
            {
                Node current = head;
                while (current != null)
                {
                    Node previous = current;
                    Node index = current.Next;
                    while (index != null)
                    {
                        if (current.Data == index.Data)
                        {
                            previous.Next = index.Next;
                        }
                        else
                        {
                            previous = index;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Merge two sorted linked lists into a single sorted linked list
        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.head;
            Node current2 = list2.head;
            LinkedList mergedList = new LinkedList();

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }

            // Add the remaining elements
            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }

        // Get the occurrences of a node
        public int GetOccurrences(int data)
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }

        // Get the total number of nodes
        public int GetNodeCount()
        {
            int nodeCount = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                nodeCount++;
                currentNode = currentNode.Next;
            }
            return nodeCount;
        }



        // Rotate linked list to the left by k places
        public void RotateLeft(int k)
        {
            if (head == null || head.Next == null || k == 0)
            {
                return;
            }

            // Calculate the length of the list
            int length = 1;
            Node tail = head;
            while (tail.Next != null)
            {
                tail = tail.Next;
                length++;
            }

            // Adjust k to be within the length of the list
            k = k % length;
            if (k == 0)
            {
                return; // No rotation needed
            }

            // Find the (k+1)th node
            Node newTail = head;
            for (int i = 1; i < k; i++)
            {
                newTail = newTail.Next;
            }

            // Rotate the list
            Node newHead = newTail.Next;
            newTail.Next = null; // Break the list at the kth node
            tail.Next = head;    // Connect the end of the list to the old head
            head = newHead;      // Update the head to the new head
        }


    }

}
