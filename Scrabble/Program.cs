using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace  Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer");
      Console.WriteLine("Enter a word: ");
      string userWord = Console.ReadLine();
      Word newWord = new Word(userWord);
      newWord.WordChecker();
      newWord.WordScorer();
      Console.WriteLine("Your score is: " + newWord.Score);
    }
  }
}