using System;
using System.Collections.Generic;

namespace Palindrome.Models
{
  public class Word
  {
    public bool CheckWord(string word)
    {
      char[] wordArray = word.ToUpper().ToCharArray();
      char[] compare = wordArray;
      Array.Reverse( compare );
      bool flag = false;
      for (int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] != compare[i])
        {
          flag = false;
        }
        else
        {
          flag = true;
        }
      }
      return flag;
    }
  }
}