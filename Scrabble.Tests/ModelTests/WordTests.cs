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

    [TestMethod]
    public void GetAll_GiveWordClassStaticArrays_Array()
    {
      Dictionary<char, int> pointDictionary = Word.PointDictionary;
      Dictionary<char, int> compareDictionary = new Dictionary<char, int>{ {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3},{'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K',5}, {'X',8}, {'J',8}, {'Q',10}, {'Z', 10}};
      CollectionAssert.AreEqual(compareDictionary, pointDictionary);
    }

    [TestMethod]
    public void WordScorer_ScoreAWord_Int()
    {
      Word newWord = new Word("Hello");
      newWord.WordChecker();
      newWord.WordScorer();
      Assert.AreEqual(8, newWord.Score);
    }
    
    [TestMethod]
    public void WordScorer_ScoreAnyWord_Int()
    {
      Word newWord = new Word("Zip");
      newWord.WordChecker();
      newWord.WordScorer();
      Assert.AreEqual(14, newWord.Score);
    }  
  }
}