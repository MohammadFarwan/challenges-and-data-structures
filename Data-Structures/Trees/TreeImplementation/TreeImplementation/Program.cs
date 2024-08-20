using TreeImplementation;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Add nodes to the BST
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        Console.WriteLine("Binary Search Tree:");
        bst.Print();

        // Check if a node exists
        bool contains = bst.Contains(7);
        Console.WriteLine($"\nContains 7: {contains}");

        // Remove a node
        bst.Remove(5);
        Console.WriteLine("\nAfter removing 5:");
        bst.Print();

        // Check if the node is removed
        contains = bst.Contains(5);
        Console.WriteLine($"\nContains 5: {contains}");


        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(4);
        Btree.Root.Left = new Node(8);
        Btree.Root.Right = new Node(7);
        Btree.Root.Left.Left = new Node(12);
        Btree.Root.Left.Right = new Node(9);

        Console.WriteLine("Original Inorder Traversal:");
        List<int> originalInorder = Btree.InOrder();
        Console.WriteLine(string.Join(", ", originalInorder)); // Output: 12, 8, 9, 4, 7

        // Create a TreeMirror object and mirror the tree
        TreeMirror treeMirror = new TreeMirror();
        treeMirror.MirrorTree(Btree);

        Console.WriteLine("\nMirrored Inorder Traversal:");
        List<int> mirroredInorder = Btree.InOrder();
        Console.WriteLine(string.Join(", ", mirroredInorder)); // Output: 7, 4, 9, 8, 12

    }
}