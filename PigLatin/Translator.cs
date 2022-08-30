using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class Translator
    {
        public static bool IsVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }
            return false;
        }


        public static bool StartsWithVowel(string word)
        {
            bool result = IsVowel(word[0]);
            return result;
        }


        public static int NumberOfCons(string word)
        {
            int index = 0;
            while (IsVowel(word[index]) == false)
            {
                index++;

                if (index == word.Length)
                {
                    return index;
                }
            }
            return index;

            //for (int i = 0; i < word.Length; i++)
            //{
                
            //}
            //return 0;
        }


        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }


        public static string PigLatinCons(string word)
        {
            int cons = NumberOfCons(word);
            string start = word.Substring(0, cons);
            string newWord = word + start + "ay";
            newWord = newWord.Remove(0, cons);
            return newWord;
        }

        public static string PigLatinize(string word)
        {
            if (StartsWithVowel(word))
            {
                return PigLatinVowels(word);
            }
            else
            {
                return PigLatinCons(word);
            }
        }


        //public static int NumberOfCons(string word)
        //{
        //    int count = 0;
        //    foreach (char letter in word)
        //    {
        //        if (!IsVowel(letter))
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            return count;
        //            break; do i need this line?
        //        }
        //    }
        //    return count;
        //}
    }
}
