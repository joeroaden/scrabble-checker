using System;

namespace Scrabble.Models 
{
  public class Word
  {
    private static char[] _onePoint = {};

    public string UserWord { get; set; }
    public char[] CharacterArray { get; set; }
    public string UpperWord { get; set; }
    public int Score { get; set; }
    
    public static char[] GetAll()
    {
      return _onePoint;
    }


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