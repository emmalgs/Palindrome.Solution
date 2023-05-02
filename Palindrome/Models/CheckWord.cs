using System;
using System.Collections.Generic;

namespace Palindrome.Models
{
  public class Word
  {
    public bool CheckWord(string word)
    {
      word = word.Replace(" ", String.Empty).ToUpper();
      char[] compare = word.ToCharArray();
      Array.Reverse( compare );
      string c = string.Join("", compare);
      Console.WriteLine(c);
      bool answer = word.Equals(c);
      return answer;
    }
  }
}