using System;
using System.Collections.Generic;
using Palindrome.Models;

namespace Palindrome
{
  class Program
  {
    static void Main()
    {
      RunApp();
    }
    public static void RunApp() 
    {
      Console.WriteLine("Check My Palindrome!");
      Console.WriteLine("Enter your palindrome to be checked:");
      try
      {
        string userInput = Console.ReadLine();
        Word newWord = new Word();
        bool response = newWord.CheckWord(userInput);
        if (response)
        {
          Console.Beep();
          Console.Beep();
          Console.WriteLine("Calculating...");
          Console.WriteLine("Great news! It's a baby palindrome!");
          PlayAgain();
        }
        else
        {
          Console.Beep();
          Console.WriteLine("We regret to inform you.");
          Console.WriteLine("It is not a palindrome.");
          PlayAgain();
        }
      }
      catch
      {
        Console.WriteLine("!!ERROR!!");
        Console.WriteLine("I can't read that.");
        PlayAgain();
      }
    }
    public static void PlayAgain()
    {
      Console.WriteLine("Play again? (Y/N)?");
      string userInput = Console.ReadLine();
      if (userInput.ToUpper() == "Y")
      {
        RunApp();
      }
      else
      {
        Console.WriteLine("BuhBye!!");
      }
    }
  }
}