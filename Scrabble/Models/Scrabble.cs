using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {   
    public string Input { get; set; }
    // public int WordScore { get; set; }

    public Word(string input)
    {
     Input = input;
    //  WordScore = wordScore;
    }
    public string MakeLower(string input)
    {
      string lower = input.ToLower();
      return lower;
    }
    public int Score(string lower)
    {
        int score = 0;

        for (int i = 0; i < lower.Length; i++)
        {
            switch (lower[i].ToString()) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
            case "l":
            case "n":
            case "r":
            case "s":
            case "t":
              score += 1;
              break;
            case "d":
            case "g":
              score += 2;
              break;
            case "b":
            case "c":
            case "m":
            case "p":
              score += 3;
              break;
            case "f":
            case "h":
            case "v":
            case "w":
            case "y":
              score += 4;
              break;
            case "k":
              score += 5;
              break;
            case "j":
            case "x":
              score += 8;
              break;
            case "q":
            case "z":
              score += 10;
              break;
            default: 
              score += 0;
              break;
          }

        }

        return score;
    }
  }
}