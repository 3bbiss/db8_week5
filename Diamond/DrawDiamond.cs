using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DrawDiamond
    {
        public static int LetterPos(char letter)
        {
            return (int)letter - 64;
        }


        public static int CalcPadding(char DLetter, char RLetter)
        {
            //return LetterPos(DLetter) - LetterPos(RLetter);
            return (int)DLetter - (int)RLetter;
        }


        // Practice: Calculate number of spaces in between
        public static int CalcSpacing(char RLetter)
        {
            if (RLetter == 'A')
            {
                return 0;
            }

            return LetterPos(RLetter) * 2 - 3;
        }



        // Practice: A function that takes number of spaces
        // and builds the space string
        // 2 -> "  "
        // 5 -> "     "
        // 0 -> ""

        public static string MakeSpaces(int num)
        {
            string numSpaces = "";

            for (int i = 1; i <= num; i++)
            {
                numSpaces += " ";
            }

            return numSpaces;
        }




        public static string OneLine(char DLetter, char RLetter)
        {
            // Create a string variable called result
            String result = "";

            // Call CalcPadding
            // Hint: Save the results here in a variable, maybe
            // called padding, because we need it here and at very 
            // end of this method

            // Call MakeSpaces using the padding and add to result

            // Add on the letter

            // Call CalcSpacing for inner spacing
           
            // Call MakeSpaces using inner spacing and add to result

            // Add on the letter again

            // Use the MakeSpace string to add the end spaces

            result =

            return result;
        }
    }
}
