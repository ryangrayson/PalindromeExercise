using System;
using System.Collections.Generic;
using System.Linq;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("computer", false)]
        [InlineData("doggy", false)]
        [InlineData("kayak", true)]

        public void  PalindromeTest(string str, bool expected )
        {
            //Arrange
            var tests = new WordSmith();
            //Act
            var actual = tests.IsAPalindrome(str);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
