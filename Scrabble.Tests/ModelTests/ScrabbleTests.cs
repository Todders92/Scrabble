using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {

    [TestMethod]
    public void Word_CheckForStringInput_String()
    {   
        string input = "Hello";
        Word newWord = new Word(input);
        Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void MakeLower_CheckInputWordIsLowerCase_String()
    {
      string input = "HELLO";
      Word newWord = new Word(input);
      // newWord.MakeLower(input);
      Assert.AreEqual(newWord.MakeLower(input), "hello");
    }

        [TestMethod]
      public void Score_CheckForLetterValue_Int()
      {
        string input = "E";
        Word newWord = new Word(input);
        string lowerWord = newWord.MakeLower(input);
        Assert.AreEqual(newWord.Score(lowerWord), 1);
      }

              [TestMethod]
      public void Score_CheckForWordValue_Int()
      {
        string input = "Hello";
        Word newWord = new Word(input);
        string lowerWord = newWord.MakeLower(input);

        Assert.AreEqual(8, newWord.Score(lowerWord));
      }
  }

}