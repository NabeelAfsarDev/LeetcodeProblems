using LeetcodeProblems.Easy;

namespace LeetCodeProblems.Tests.Easy
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(505, true)]
        [InlineData(-3000, false)]
        [InlineData(62651, false)]
        public void IsPalindromeNumber_WhenCalled_ReturnsTrueOrFalse(int number, bool expected)
        {
            //Arrange
            bool result = PalindromeNumber.IsPalindrome(number);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}