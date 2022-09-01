using Diamond;

namespace Diamond_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneLine1()
        {
            // Diamon letter: E, row letter C
            // Expected "  C   C  "
            string actual = DrawDiamond.OneLine('E', 'C');
            string expected = "  C   C  ";
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData('E', 'A', "    A    ")]
        [InlineData('E', 'B', "   B B   ")]
        [InlineData('E', 'C', "  C   C  ")]
        [InlineData('E', 'D', " D     D ")]
        [InlineData('E', 'E', "E       E")]
        [InlineData('C', 'A', "  A  ")]
        [InlineData('C', 'B', " B B ")]
        [InlineData('C', 'C', "C   C")]
        public void TestOneLine(char dLetter, char rLetter, string expected)
        {
            string actual = DrawDiamond.OneLine(dLetter, rLetter);
            Assert.Equal(expected, actual);
        }





        [Fact]
        public void TestCalcPadding1()
        {
            int actual = DrawDiamond.CalcPadding('E', 'C');
            Assert.Equal(2, actual);
            //int expected = 2;
            //Assert.Equal(expected, actual);

        }




        [Theory]
        [InlineData('E', 'A', 4)]
        [InlineData('E', 'B', 3)]
        [InlineData('E', 'C', 2)]
        [InlineData('E', 'D', 1)]
        [InlineData('E', 'E', 0)]

        [InlineData('C', 'A', 2)]
        [InlineData('C', 'B', 1)]
        [InlineData('C', 'C', 0)]
        public void TestCalcPadding(char dLetter, char rLetter, int expected)
        {
            int actual = DrawDiamond.CalcPadding(dLetter, rLetter);
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void TestSpacing()
        {
            int actual = DrawDiamond.CalcSpacing('C');
            Assert.Equal(3, actual);
        }




        [Theory]
        [InlineData('A', 0)]
        [InlineData('B', 1)]
        [InlineData('C', 3)]
        [InlineData('D', 5)]
        [InlineData('E', 7)]
        [InlineData('Z', 49)]

        public void TestSpacing2(char rLetter, int expected)
        {
            int actual = DrawDiamond.CalcSpacing(rLetter);
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void TestMakeSpaces()
        {
            string actual = DrawDiamond.MakeSpaces(3);
            Assert.Equal("   ", actual);
        }



        [Theory]
        [InlineData(0, "")]
        [InlineData(1, " ")]
        [InlineData(2, "  ")]
        [InlineData(3, "   ")]
        [InlineData(4, "    ")]
        [InlineData(5, "     ")]
        [InlineData(10, "          ")]
        
        public void TestMakeSpaces1(int Num, string expected)
        {
            string actual = DrawDiamond.MakeSpaces(Num);
            Assert.Equal(expected, actual);
        }


    }
}