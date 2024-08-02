using StackAndQueue.ReverseStackUsingQueue;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //========= [ Stack example ] =========
            Console.WriteLine("========= [ Stack example ] =========");

            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);
            Console.WriteLine(stack);

            int popped = stack.Pop();
            Console.WriteLine("Popped: " + popped);

            int peeked = stack.Peek();
            Console.WriteLine("Peeked: " + peeked);

            bool isEmptyStack = stack.IsEmpty();
            Console.WriteLine("Is stack empty: " + isEmptyStack);


            //========= [ Queue example ] =========

            Console.WriteLine("\n========= [ Queue example ] ========="); 

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.PrintQueue();

            int dequeued = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeued);

            int peekedQueue = queue.Peek();
            Console.WriteLine("Peeked: " + peekedQueue);

            bool isEmptyQueue = queue.IsEmpty();
            Console.WriteLine("Is queue empty: " + isEmptyQueue);


            //========= [ StackWithReverse example ] =========

            Console.WriteLine("\n========= [ StackWithReverse example ] =========");
            
            StackWithReverse stack1 = new StackWithReverse();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            Console.WriteLine(stack1);
            stack1.ReverseStack();
            Console.WriteLine(stack1);

            stack1.Push(6);
            stack1.Push(7);
            Console.WriteLine(stack1);
            stack1.ReverseStack();
            Console.WriteLine(stack1);





            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }
    }
}
