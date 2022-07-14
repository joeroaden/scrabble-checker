using System;

namespace Scrabble.Models 
{
  public class Word
  {
    public static char[] OnePoint = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
    public static char[] TwoPoint = { 'D', 'G' };
    public static char[] ThreePoint = { 'B', 'C', 'M', 'P' };
    public static char[] FourPoint = { 'F', 'H', 'V' , 'W', 'Y'};
    public static char[] FivePoint = { 'K' };
    public static char[] EightPoint = { 'J', 'K' };
    public static char[] TenPoint = { 'Q', 'Z' };

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
      Score += 8;
    }
  }
}