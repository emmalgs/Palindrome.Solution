using System;
using System.Collections.Generic;
using Palindrome.Models;

namespace Palindrome
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Check My Palindrome!");
      Console.WriteLine("Enter your palindrome to be checked:");
      string userInput = Console.ReadLine();
      Word newWord = new Word();
      bool response = newWord.CheckWord(userInput);
      if (response == true)
      {
        Console.WriteLine("Calculating...");
        Console.WriteLine("Great news! It's a baby palindrome!");
      }
      else
      {
        Console.WriteLine("We regret to inform you.");
        Console.WriteLine("It is not a palindrome.");
      }
    }
  }
}