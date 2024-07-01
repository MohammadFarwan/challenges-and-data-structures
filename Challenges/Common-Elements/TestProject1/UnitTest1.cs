using Common_Elements;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CommonElements_CheckCommonElements1()
        {
            // Arrange
            int[] firstArr = new int[] { 1, 2, 3, 0 };
            int[] secondArr = new int[] { 2, 3, 4, 9 };

            // Act
            int[] result = Program.CommonElements(firstArr, secondArr);

            // Assert
            Assert.Equal(new int[] { 2, 3 }, result);
        }

        [Fact]
        public void CommonElements_CheckCommonElements2()
        {
            // Arrange
            int[] firstArr = new int[] { 79, 8, 15 };
            int[] secondArr = new int[] { 23, 79, 8 };

            // Act
            int[] result = Program.CommonElements(firstArr, secondArr);

            // Assert
            Assert.Equal(new int[] { 79, 8 }, result);
        }
    }
}