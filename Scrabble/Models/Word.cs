using System;

namespace Scrabble.Models 
{
  public class Word
  {
    public string UserWord { get; set; }

    public Word(string userWord)
    {
      UserWord = userWord.ToUpper();
    }
  }
}