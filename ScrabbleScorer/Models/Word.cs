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
      int totalSum = 0;
      foreach (string letter in letterArray)
      {
        if (letter.Contains("a" || "e" || "i" || "o" || "u" || "l" || "n" || "r" || "s" || "t"))
        {
          int letterValue = 1;
          totalSum += letterValue;
        }
        else if (letter.Contains("d" || "g"))
        {
          int letterValue = 2;
          totalSum += letterValue;
        }   // /[aeioulnrst]/g
        else if (letter.Contains("b" || "c" || "m" || "p"))
        {
          int letterValue = 3;
          totalSum += letterValue;
        }
        else if (letter.Contains("f" || "h" || "v" || "w" || "y"))
        {
          int letterValue = 4;
          totalSum += letterValue;
        }
        else if (letter.Contains("k"))
        {
          int letterValue = 5;
          totalSum += letterValue;
        }
        else if (letter.Contains("j" || "x"))
        {
          int letterValue = 8;
          totalSum += letterValue;
        }
        else if (letter.Contains("q" || "z"))
        {
          int letterValue = 10;
          totalSum += letterValue;
        }
      }
    }
  }
}
