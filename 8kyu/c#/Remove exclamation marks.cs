// Write function RemoveExclamationMarks which removes all exclamation marks from a given string.

public class Kata
{
  public static string RemoveExclamationMarks(string s)
  {
    s= s.Replace("!", "");
    return s;
  }
}