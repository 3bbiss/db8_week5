using ListDemo;

namespace ListDemo_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRemoveLargest1()
        {
            List<int> values = new List<int>() { 5, 20, 6, 3 };
            List<int> actual = MyLists.RemoveLargest(values);
            List<int> expected = new List<int>() { 5, 6, 3 };


            Assert.Equal(expected, actual);
        }


        // What to test?
        // A basic one {5, 20, 6, 3} -> {5, 6, 3}
        // Duplicare largest {5, 20, 6, 20, 3} -> {5, 6, 20, 3}
        [Theory]
        [InlineData(new int[] { 5, 20, 6, 3 }, new int[] { 5, 6, 3 })]
        [InlineData(new int[] { 5, 20, 6, 20, 3 }, new int[] { 5, 6, 20, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5 })]
        [InlineData(new int[] { 5 }, new int[] { })]
        public void TestRemoveLargest2(int[] valuesArray, int[] expectedArray)
        {
            List<int> values = new List<int>(valuesArray);
            List<int> expected = new List<int>(expectedArray);

            List<int> actual = MyLists.RemoveLargest(values);
            Assert.Equal(expected, actual);
        }

        // For demo purposes, let's try out Assert.Contains()

        [Fact]
        public void TestContainsDemo()
        {
            List<int> myList = new List<int>() { 5, 20, 6, 3 };
            List<int> result = MyLists.RemoveLargest(myList);

            // Let's make sure 3 is still in the list
            // Assert.True(result.Contains(3));

            Assert.Contains<int>(3, result);

        }


        [Theory]
        [InlineData(new string[] {"hello", "world", "bot", "computer"} , new string[] { "helloyay", "worldyay", "botyay", "computeryay" })]

        public void TestPigLatin(string[] wordsArray, string[] expectedArray)
        {
            List<string> words = new List<string>(wordsArray);
            List<string> expected = new List<string>(expectedArray);

            List<string> actual = MyLists.PigLatin(words);
            Assert.Equal(expected, actual);
        }




    }
}