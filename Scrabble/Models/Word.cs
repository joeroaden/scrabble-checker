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
      for (int index = 0; index < CharacterArray.Length; index++)
      {
        for (int indexOnePoint = 0; indexOnePoint < OnePoint.Length; indexOnePoint++)
        {
          if ( CharacterArray[index] == OnePoint[indexOnePoint])
          {
            Score += 1;
          }
        }
        for (int indexTwoPoint = 0; indexTwoPoint < TwoPoint.Length; indexTwoPoint++)
        {
          if ( CharacterArray[index] == TwoPoint[indexTwoPoint])
          {
            Score += 2;
          }
        }
        for (int indexThreePoint = 0; indexThreePoint < ThreePoint.Length; indexThreePoint++)
        {
          if ( CharacterArray[index] == ThreePoint[indexThreePoint])
          {
            Score += 3;
          }
        }
        for (int indexFourPoint = 0; indexFourPoint < FourPoint.Length; indexFourPoint++)
        {
          if ( CharacterArray[index] == FourPoint[indexFourPoint])
          {
            Score += 4;
          }
        }
        for (int indexFivePoint = 0; indexFivePoint < FivePoint.Length; indexFivePoint++)
        {
          if ( CharacterArray[index] == FivePoint[indexFivePoint])
          {
            Score += 5;
          }
        }
        for (int indexEightPoint = 0; indexEightPoint < EightPoint.Length; indexEightPoint++)
        {
          if ( CharacterArray[index] == EightPoint[indexEightPoint])
          {
            Score += 8;
          }
        }
        for (int indexTenPoint = 0; indexTenPoint < TenPoint.Length; indexTenPoint++)
        {
          if ( CharacterArray[index] == TenPoint[indexTenPoint])
          {
            Score += 10;
          }
        }
      }
    }
  }
}