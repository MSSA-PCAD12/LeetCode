﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public class CodilitySample1
    {
        public string getNote(string L, int[] B)
        {
            int starting = 0;
            var result = new StringBuilder(L[starting].ToString());
            int nextChild = B[starting];

            while (nextChild != 0)
            {
                result.Append(L[nextChild]);
                nextChild = B[nextChild];
            }
            return result.ToString();
        }
    }
}

//Examples:
//There are M children, ordered from 0 to M-1, involved in a game.  
//The N-th child is assigned a letter: L[N].  At the 
//start the 0th child gives a note, consisting of one 
//letter L[0], to the B[0]-th child.  When the N-th 
//child gets the note, they add their letter L[N] 
//to the note and pass it to B[N].  The game is over when 
//the 0th child gets the note.  Find the final note.

//Write a function:

//function getNote(L, B);

//that accepts String L and an array of integers B, both of 
//equal length, and returns a string with the final note
//given to the 0th child.
//There are M children, ordered from 0 to M-1, involved in a game.  
//The N-th child is assigned a letter: L[N].  At the 
//start the 0th child gives a note, consisting of one 
//letter L[0], to the B[0]-th child.  When the N-th 
//child gets the note, they add their letter L[N] 
//to the note and pass it to B[N].  The game is over when 
//the 0th child gets the note.  Find the final note.

//Write a function:

//function getNote(L, B);

//that accepts String L and an array of integers B, both of 
//equal length, and returns a string with the final note
//given to the 0th child.


//1. Given L = "cdeo" and B = [3, 2, 0, 1], the function 
//returns "code".  The 0th child gives a note "c" to the 
//3rd child.  Next, the 3rd child gives the note "co" to 
//the 1st child.  The 1st child gives the note "cod" to 
//the 2nd child.  After adding the letter 'e' to it, 
//the 2nd child gives it to the 0th child.  The final 
//note, given to the 0th child, is "code".

//2. Given L = "cdeenetpi" and B = [5, 2, 0, 1, 6, 4, 8, 3, 7], 
//the function returns "centipede".

//3. Given L = "bytdag" and B = [4, 3, 0, 1, 2, 5], the
//function returns "bat".  NOTE: not all letters 
//from L must be used.
    
//M is an integer from [1... 1,000];
//String L consists only of lowercase letters (a-z);
//B is all integers within range [0... M-1];
//L and B are both of length M.Examples:

//1. Given L = "cdeo" and B = [3, 2, 0, 1], the function 
//returns "code".  The 0th child gives a note "c" to the 
//3rd child.  Next, the 3rd child gives the note "co" to 
//the 1st child.  The 1st child gives the note "cod" to 
//the 2nd child.  After adding the letter 'e' to it, 
//the 2nd child gives it to the 0th child.  The final 
//note, given to the 0th child, is "code".

//2. Given L = "cdeenetpi" and B = [5, 2, 0, 1, 6, 4, 8, 3, 7], 
//the function returns "centipede".

//3. Given L = "bytdag" and B = [4, 3, 0, 1, 2, 5], the
//function returns "bat".  NOTE: not all letters 
//from L must be used.
    
//M is an integer from [1... 1,000];
//String L consists only of lowercase letters (a-z);
//B is all integers within range [0... M-1];
//L and B are both of length M.