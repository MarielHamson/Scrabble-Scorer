using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models
{
  public class Word
  {
    public string Input { get; }

    public Word(string input)
    {
      Input = input;
    }
    // public string Description { get; set; }
    public string[] StringToLetterArray(string input)
    {
      string[] letterArray = input.Split(",");
      return letterArray;

      // char[] letterArray = input.ToCharArray();
      // return letterArray;
    }
    public int CheckForScore(string[] letterArray)
    {

    }
  }
}