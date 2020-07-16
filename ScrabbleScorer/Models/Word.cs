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
    public string[] StringToLetterArray()
    {
      string[] letterArray = { };
      return letterArray;

      // Console.WriteLine("letterArray");// properties, methods, etc. will go here.
      // return String;
    }
  }
}