using System;

namespace PalindromeExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.  
//→ Right click dependencies in PalindromeExerciseTests to check and add if need be---DONE

//Create a class named WordSmith in your PalindromeExercise project file.  This is where you will eventually create your IsAPalindrome() method---DONE

//In your WordSmith class, you will create a method (IsAPalindrome) that will take a parameter of type string and return a value of type bool.  If the given input is a palindrome – return true, else return false. 

//Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

//Remove the [Fact] portion and replace it with:
//[Theory]
//[InlineData()] ← you will need to put some test data and expected result here.  

//For example [InlineData(“racecar”, true)]

//Finish the test with arrange, act, assert and make your IsAPalindrome method pass the tests

