using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void WordConstructor_CreatingInstanceOfWord_Word()
    {
      {
        Word newWord = new Word(); //We pass in "test" as an argument here.
        Assert.AreEqual(typeof(Word), newWord.GetType());
      }
      //Arrange
      //Act
      //Assert.AreEqual(ExpectedResult, Code_To_Test);
    }
  }
}