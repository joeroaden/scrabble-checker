using System;

namespace Scrabble.Models 
{
  public class Word
  {
    public static char[] OnePoint = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };

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


  }
}