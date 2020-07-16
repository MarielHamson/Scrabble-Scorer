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
  }
}