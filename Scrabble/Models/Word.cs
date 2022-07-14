using System;

namespace Scrabble.Models 
{
  public class Word
  {
    public string UserWord { get; set; }
    public char[] CharacterArray { get; set; }

    public Word(string userWord)
    {
      UserWord = userWord.ToUpper();
    }

    public void  WordChecker () {
      CharacterArray = UserWord.ToCharArray();
    }
  }
}