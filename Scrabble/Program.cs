using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Program
{
  public class Scrabble
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word:");

      string response = Console.ReadLine();

      Word newWord = new Word(response);
      string lower =newWord.MakeLower(response);
      Console.WriteLine("the score of your word is : " + newWord.Score(lower) + " points!");
      EndState();
    }
    public static void EndState()
        {
          Console.WriteLine("would you like to try another word? [y] yes [n] no");
          string playAgain = Console.ReadLine();
          if(playAgain == "y")
          {
            Main();
          }
          else if (playAgain == "n")
          {
            Console.WriteLine("goodbye");
          }
          else
          {
            EndState();
          }
        }
  }
}