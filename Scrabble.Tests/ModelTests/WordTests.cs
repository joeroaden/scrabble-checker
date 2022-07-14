using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Test
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Word_MakesAnInstanceOfWordClass_String()
    {
      Word newWord = new Word("Hello");
      Assert.AreEqual("HELLO", newWord.UserWord);
    }

    [TestMethod]
    public void Word_MakesWordAllUppercase_String()
    {
      Word newWord = new Word("Hello");
      Assert.AreEqual("HELLO", newWord.UserWord);
    }

    [TestMethod]
    public void WordChecker_MakeWordIntoCharArray_Array()
    {
      Word newWord = new Word("Hello");
      newWord.WordChecker();
      char [] checkArray = {'H', 'E', 'L', 'L', 'O'};
      CollectionAssert.AreEqual(checkArray, newWord.CharacterArray);
    }
  }
}