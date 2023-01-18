using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {   // Palindromes are words or phrases that read the same backward and forward, letter for letter, number for number, or word for word.

        [Theory]
        [InlineData("racecar",  true)]
        [InlineData("hello", false)]
        [InlineData("Civic", true)]
        [InlineData("A nut for a jar of tuna", false)]
        [InlineData("A man, a plan, a canal – Panama", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WorkSmith();

            //act
            var actual = WorkSmith.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);


        }
    }
}
