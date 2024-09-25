using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListClass = LinkedList.LinkedList;


public class RotateLinkedListTests
{
    [Fact]
    public void Rotate_By_Zero_Should_Not_Change_List()
    {
        // Arrange
        var list = new LinkedListClass();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);

        var expectedOutput = "Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null";

        // Act
        list.RotateLeft(0);

        // Assert
        Assert.Equal(expectedOutput, GetListAsString(list));
    }

    [Fact]
    public void Rotate_By_Value_Greater_Than_List_Length_Should_Work_Correctly()
    {
        // Arrange
        var list = new LinkedListClass();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);

        // Rotating by 7 is the same as rotating by 1 (since 7 % 6 == 1)
        var expectedOutput = "Head -> 2 -> 3 -> 4 -> 5 -> 6 -> 1 -> Null";

        // Act
        list.RotateLeft(7);

        // Assert
        Assert.Equal(expectedOutput, GetListAsString(list));
    }

    // Utility method to get the string representation of the list
    private string GetListAsString(LinkedListClass list)
    {
        var current = list.head;
        var result = new System.Text.StringBuilder();
        result.Append("Head -> ");
        while (current != null)
        {
            result.Append(current.Data + " -> ");
            current = current.Next;
        }
        result.Append("Null");
        return result.ToString();
    }
}
