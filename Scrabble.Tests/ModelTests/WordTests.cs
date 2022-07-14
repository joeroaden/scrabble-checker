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
      Assert.AreEqual("Hello", newWord.UserWord);
    }

    [TestMethod]
    public void Word_MakesWordAllUppercase_String()
    {
      Word newWord = new Word("Hello");
      newWord.WordChecker();
      Assert.AreEqual("HELLO", newWord.UpperWord);
    }

    [TestMethod]
    public void WordChecker_MakeWordIntoCharArray_Array()
    {
      Word newWord = new Word("Hello");
      newWord.WordChecker();
      char [] checkArray = {'H', 'E', 'L', 'L', 'O'};
      CollectionAssert.AreEqual(checkArray, newWord.CharacterArray);
    }

    [TestMethod]
    public void Word_GiveWordInstanceAScoreProperty_Int()
    {
      Word newWord = new Word("Hello");
      Assert.AreEqual( 0, newWord.Score);
    }
  }
}