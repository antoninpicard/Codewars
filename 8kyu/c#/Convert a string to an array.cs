// Write a function to split a string and convert it into an array of words.

// Examples (Input ==> Output):
// "Robin Singh" ==> ["Robin", "Singh"]

// "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
namespace Solution {
  using System;
  using System.Linq;

  public class Solution
  {
    public static string[] StringToArray(string str)
    {
      return str.Split();
    }
  }
}