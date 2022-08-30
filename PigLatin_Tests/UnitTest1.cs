
using PigLatin;

namespace PigLatin_Tests
{
    public class UnitTest1
    {
        // Here we'll test five individual letters separately
        // But we have a shortcut
        //[Fact]
        //public void TestIsVowelA()
        //{
        //    bool actual = Translator.IsVowel('a');
        //    Assert.True(Translator.IsVowel('a'));
        //}

        //[Fact]
        //public void TestIsVowelE()
        //{
        //    bool actual = Translator.IsVowel('e');
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsVowelI()
        //{
        //    bool actual = Translator.IsVowel('i');
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsVowelO()
        //{
        //    bool actual = Translator.IsVowel('o');
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsVowelU()
        //{
        //    bool actual = Translator.IsVowel('u');
        //    Assert.True(actual);
        //}

        [Theory]
        [InlineData('a')]
        [InlineData('e')]
        [InlineData('i')]
        [InlineData('o')]
        [InlineData('u')]
        public void TestIsVowel(char value)
        {
            bool actual = Translator.IsVowel(value);
            Assert.True(actual);
        }


        [Theory]
        [InlineData('s')]
        [InlineData('z')]
        [InlineData('y')]
        public void TestIsVowelCons(char value)
        {
            bool actual = Translator.IsVowel(value);
            Assert.False(actual);
        }





        //[Fact]
        //public void TestIsVowelS()
        //{
        //    bool actual = Translator.IsVowel('S');
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void TestIsVowelZ()
        //{
        //    bool actual = Translator.IsVowel('Z');
        //    Assert.False(actual);
        //}


        [Fact]
        public void TestStartsWithVowel()
        {
            bool actual = Translator.StartsWithVowel("ant");
            Assert.True(actual);
        }

        [Fact]
        public void TestStartsWithCons()
        {
            bool actual = Translator.StartsWithVowel("car");
            Assert.False(actual);
        }


        //[Fact]
        //public void TestNumberOfCons()
        //{
        //    int actual = Translator.NumberOfCons("banana");
        //    Assert.Equal(1, actual);
        //}


        //[Fact]
        //public void TestNumberOfCons2()
        //{
        //    int actual = Translator.NumberOfCons("shout");
        //    Assert.Equal(2, actual);
        //}


        //[Fact]
        //public void TestNumberOfCons3()
        //{
        //    int actual = Translator.NumberOfCons("school");
        //    Assert.Equal(3, actual);
        //}


        //[Fact]
        //public void TestNumberOfCons6()
        //{
        //    int actual = Translator.NumberOfCons("rhythm");
        //    Assert.Equal(6, actual);
        //}

        [Theory]
        [InlineData("banana", 1)]
        [InlineData("shout", 2)]
        [InlineData("school", 3)]
        [InlineData("rhythm", 6)]

        public void TestNumCons(string value, int expected)
        {
            int actual = Translator.NumberOfCons(value);
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData("apple", "appleyay")]
        [InlineData("every", "everyyay")]
        [InlineData("open", "openyay")]
        public void TestPLVowel(string value, string expected)
        {
            string actual = Translator.PigLatinVowels(value);
            Assert.Equal(expected, actual);
        }



        //[Fact]
        //public void TestPLVowel1()
        //{
        //    string actual = Translator.PigLatinVowels("apple");
        //    Assert.Equal("appleyay", actual);
        //}


        //[Fact]
        //public void TestPLVowel2()
        //{
        //    string actual = Translator.PigLatinVowels("every");
        //    Assert.Equal("everyyay", actual);
        //}


        [Theory]
        [InlineData("school", "oolschay")]
        [InlineData("something", "omethingsay")]
        [InlineData("rhythm", "rhythmay")]
        public void TestPLCons(string value, string expected)
        {
            string actual = Translator.PigLatinCons(value);
            Assert.Equal(expected, actual);
        }


        //[Fact]
        //public void TestPLCons1()
        //{
        //    string actual = Translator.PigLatinCons("school");
        //    Assert.Equal("oolschay", actual);
        //}


        //[Fact]
        //public void TestPLCons2()
        //{
        //    string actual = Translator.PigLatinCons("something");
        //    Assert.Equal("omethingsay", actual);
        //}


        //[Fact]
        //public void TestPLCons3()
        //{
        //    string actual = Translator.PigLatinCons("rhythm");
        //    Assert.Equal("rhythmay", actual);
        //}



        [Theory]
        [InlineData("eat", "eatyay")]
        [InlineData("banana", "ananabay")]
        public void TestPigLatinize(string value, string expected)
        {
            string actual = Translator.PigLatinize(value);
            Assert.Equal(expected, actual);
        }


        //[Fact]
        //public void TestPigLatin1()
        //{
        //    string actual = Translator.PigLatinize("eat");
        //    Assert.Equal("eatyay", actual);
        //}

        //[Fact]
        //public void TestPigLatin2()
        //{
        //    string actual = Translator.PigLatinize("banana");
        //    Assert.Equal("ananabay", actual);
        //}



    }
}