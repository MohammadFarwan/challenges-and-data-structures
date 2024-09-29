using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class RightViewTest
    {
        // Helper method to capture console output
        private string CaptureConsoleOutput(Action action)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                return sw.ToString().Trim();
            }
        }

        [Fact]
        public void PrintRightView_ExampleTree_ShouldPrintCorrectRightView()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(2);
            binaryTree.Root.Left = new Node(3);
            binaryTree.Root.Right = new Node(5);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Right.Right = new Node(6);
            binaryTree.Root.Left.Left.Right = new Node(7);

            // Act
            string output = CaptureConsoleOutput(() => binaryTree.PrintRightView());

            // Assert
            Assert.Equal("2 5 6 7", output);
        }

        [Fact]
        public void PrintRightView_TreeWithRightNodesOnly_ShouldPrintCorrectRightView()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new Node(10);
            binaryTree.Root.Right = new Node(20);
            binaryTree.Root.Right.Right = new Node(30);
            binaryTree.Root.Right.Right.Right = new Node(40);

            // Act
            string output = CaptureConsoleOutput(() => binaryTree.PrintRightView());

            // Assert
            Assert.Equal("10 20 30 40", output);
        }
    }
}
