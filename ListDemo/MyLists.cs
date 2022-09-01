using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    public class MyLists
    {
        // A method that takes a list of ints and removes
        // the largest num
        // E.g. {5, 20, 6, 3} -> {5, 6, 3}
        // Duplicate largest? Remove the first.
        // All the same: {5, 5, 5, 5,} -> {5, 5, 5}
        // Only one: {5} -> {}
        // Empty list? -> Empty List.

        public static List<int> RemoveLargest(List<int> theList)
        {
            List<int> result = new List<int>(theList);
            if (result.Count == 0)
            {
                return result;
            }

            result.Remove(result.Max());
            return result;
        }


        // A method that takes a list of strings
        // and add "yay" to the end of each string
        // E.g. {"hello", "world", "computer"} -> {"helloyay", "worldyay", "computeryay"}

        public static List<string> PigLatin(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                words[i] += "yay";
            }

            return words;
        }


    }
}
