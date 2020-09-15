using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string str)
        {
            return (str.SequenceEqual(str.Reverse()));

        }           
            
            
    }
}
       


            
            


