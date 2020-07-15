using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayWithStrings
{
    class Utility
    {
        public static string LastWord(int position, String stringVariable, char charToPass)
        {
            string[] res = stringVariable.Split(charToPass.ToString());
            if (position >= res.Length || res[position] == null )
            {
                Console.WriteLine("No word is there at position " + position);
                return "";
            }
            else
                return res[position];
        }
        public List<String> GetPallindromes(string[] input)
        {
            List <String> lst = new List<String>();
            foreach(String word in input)
            {
            
                char[] arrString = word.ToCharArray();
                Array.Reverse(arrString);
                string reversedstring = new String(arrString);

                if(word.Equals(reversedstring))
                lst.Add(word);

            }
            return lst;

        }
    }
}
