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

        // newWord.Score();
        Console.WriteLine(newWord.Score(response));
    }
  }
}