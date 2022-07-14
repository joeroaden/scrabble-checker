using System;

namespace Scrabble.Models 
{
  public class Word
  {
    public string UserWord { get; set; }
    public char[] CharacterArray { get; set; }
    public string UpperWord { get; set; }


    public Word(string userWord)
    {
      UserWord = userWord;
    }

    public void  WordChecker () 
    {
      UpperWord = UserWord.ToUpper();
      CharacterArray = UpperWord.ToCharArray();
    }
  }
}