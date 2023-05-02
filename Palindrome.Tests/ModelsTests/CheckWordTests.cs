using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System;
using System.Collections.Generic;

namespace Palindrome.TestTools
{
  [TestClass]
  public class CheckWordTests
  {
    [TestMethod]
    public void CheckWOrd_ReturnsTrueIfPalindrome_Bool()
    {
      Word newWord = new Word();
      string w = "bob";
      Assert.AreEqual(true, newWord.CheckWord(w));
    }

    [TestMethod]
    public void CheckWOrd_ReturnsTrueForLongWithSpace_Bool()
    {
      Word newWord = new Word();
      string w = "god a red nugget a fat egg under a dog";
      Assert.AreEqual(true, newWord.CheckWord(w));
    }

    [TestMethod]
    public void CheckWOrd_ReturnsFalseForNotPalindrome_Bool()
    {
      Word newWord = new Word();
      string w = "holy mackrel";
      Assert.AreEqual(false, newWord.CheckWord(w));
    }
  }
}