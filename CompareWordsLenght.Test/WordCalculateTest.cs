using CompareWordsLenght.Business;
using Xunit;

namespace CompareWordsLenght.Test
{
    public class WordCalculateTest
    {
        [Fact]
        public void LenghtCalculate()
        {
            //arrange
            var wordCalculate = new WordCalculate();
            string[] moc = new string[] { "xxx", "yyyy", "zzzzz", "abcdefghij" };
            //act
            var result = wordCalculate.WordsToCalculate(moc);
            ///assert
            Assert.Equal("abcdefghij", result);

        }
    }
}