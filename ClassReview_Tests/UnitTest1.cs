using Xunit;
using ClassReview;

namespace ClassReview_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPerim()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.Perim();
            Assert.Equal(60, actual);
        }

        [Fact]
        public void TestArea()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.Area();
            Assert.Equal(200, actual);
        }

        [Fact]
        public void TestCheckRange9()
        {
            bool actual = Misc.CheckRange(9);
            Assert.Equal(false, actual);
        }


        [Fact]
        public void TestCheckRange10()
        {
            bool actual = Misc.CheckRange(10);
            Assert.Equal(true, actual);
        }


        [Fact]
        public void TestCheckRange15()
        {
            bool actual = Misc.CheckRange(15);
            Assert.Equal(true, actual);
        }


        [Fact]
        public void TestCheckRange20()
        {
            bool actual = Misc.CheckRange(20);
            Assert.Equal(true, actual);
        }

        [Fact]
        public void TestCheckRange21()
        {
            bool actual = Misc.CheckRange(21);
            Assert.Equal(false, actual);
        }


        [Fact]
        public void TestPosNegMinus2()
        {
            int actual = Misc.PosNeg(-2);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestPosNegMinus1()
        {
            int actual = Misc.PosNeg(-1);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestPosNegZero()
        {
            int actual = Misc.PosNeg(0);
            Assert.Equal(0, actual);
        }

        [Fact]
        public void TestPosNegOne()
        {
            int actual = Misc.PosNeg(1);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void TestPosNegtwo()
        {
            int actual = Misc.PosNeg(2);
            Assert.Equal(1, actual);
        }
    }
}