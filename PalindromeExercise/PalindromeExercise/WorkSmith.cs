using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WorkSmith
    {        public static bool IsAPalindrome(string word)
        {
            //reverse the word //ex. racecar ---7 charaters  --> 6 indexs (0 to 7)
            var reversed = "";

            for (int i = word.Length - 1;  i >= 0; i--) 
            {
                reversed += word[i];
            }

            //compare the original with the reversed
            if(reversed.ToLower() == word.ToLower())
            {
                return (reversed.ToLower() == word.ToLower());
            }
            else
            {
                return false; 
            }


            //return whether they are the same or not
        }

        
    }

    

}
