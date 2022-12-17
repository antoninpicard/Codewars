// You will be given a list of strings. You must sort it alphabetically (case-sensitive, and based on the ASCII values of the chars) and then return the first value.

// The returned value must be a string, and have "***" between each of its letters.

// You should not remove or add elements from/to the array.

using System;
using System.Linq;

public class Kata
{
  static int Comparer(string s1, string s2)
        {
            if (char.IsUpper(s1[0]) && char.IsLower(s2[0])) return -1;
            if (char.IsUpper(s2[0]) && char.IsLower(s1[0])) return 1;
            return String.CompareOrdinal(s1, s2);
        }

        public static string TwoSort(string[] s)
        {
            var list = s.ToList();
            list.Sort(Comparer);
            return string.Join("***", list.First().Select(c => c));
        }

}