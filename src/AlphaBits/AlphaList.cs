using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaBits
{
    public class AlphaList
    {
        public List<char> userList = new List<char>();

        public AlphaList()
        {
            List<char> userList = new List<char>();
        }

        public void addChar(char charToAdd)
        {
            charToAdd = Char.ToLower(charToAdd);
            string thingToAdd = charToAdd.ToString(); 

            if (userList.Contains(charToAdd))
            {
                Console.WriteLine("Sorry! You've already added {0}", thingToAdd);
                return;
            }
            if (!Char.IsLetter(charToAdd))
            {
                Console.WriteLine("Sorry! '{0}' is not a letter", thingToAdd);
                return;
            }
            userList.Add(charToAdd);
            //if list already contains char, or char is not a letter throw an error
        }

        public int listLength()
        {
            return userList.Count();
        }

        public string returnList()
        {
            string combindedString = string.Join(",", userList.ToArray());
            return combindedString;
        }
    }
}
;