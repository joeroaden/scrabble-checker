using System;
using System.Collections.Generic;

namespace Scrabble.Models 
{
  public class Word
  {
    public static Dictionary<char, int> PointDictionary = new Dictionary<char, int>{ {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3},{'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K',5}, {'X',8}, {'J',8}, {'Q',10}, {'Z', 10}};   

    public string UserWord { get; set; }
    public char[] CharacterArray { get; set; }
    public string UpperWord { get; set; }
    public int Score { get; set; }

    public Word(string userWord)
    {
      UserWord = userWord;
    }

    public void  WordChecker () 
    {
      UpperWord = UserWord.ToUpper();
      CharacterArray = UpperWord.ToCharArray();
    }

    public void WordScorer()
    {
      for (int index = 0; index < CharacterArray.Length; index++)
      {
        foreach(var item in PointDictionary)
        {
          if (CharacterArray[index] == item.Key)
          {
            Score += item.Value;
          }
        }
      }
    }
  }
}