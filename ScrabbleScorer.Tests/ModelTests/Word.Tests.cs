using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void WordConstructor_CreatingInstanceOfWord_Word()
    {
      Word newWord = new Word("test"); //We pass in "test" as an argument here.
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    //Arrange
    //Act
    //Assert.AreEqual(ExpectedResult, Code_To_Test);
    [TestMethod]
    public void WordConstructor_WordReceivedIsWordReturned_True()
    {
      string input = "apple";
      Word newWord = new Word(input);
      string output = newWord.Input;
      Assert.AreEqual(output, input);
    }
    [TestMethod]
    public void StringToLetterArray_WordReceivedIsSplitIntoArray_True()
    {
      string input = "apple";
      Word newWord = new Word(input);
      string[] testArray = { "a", "p", "p", "l", "e" };
      string[] letterArray = newWord.StringToLetterArray("test");
      Assert.AreEqual(testArray.GetType(), letterArray.GetType());
      // string input = "apple";
      // Word newWord = new Word(input);  // String.Split(",");
      // string output = newWord.Input;
      // string[] letterArray = output.StringToLetterArray();
      // string[] appleArray = { "a", "p", "p", "l", "e" };
      // Assert.AreEqual(appleArray, letterArray);
    }
    [TestMethod]
    public void CheckForScore_CharacterValuesAreSummed_True()
    {
      Word newWord = new Word("apple");
      string[] lettersSeparated = newWord.StringToLetterArray();
      int testScore = 8;
      int score = newWord.CheckForScore();
      Assert.AreEqual()

    }
  }
}
