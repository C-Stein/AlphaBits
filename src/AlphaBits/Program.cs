using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaBits
{
    public class Program
    {
        public void Main(string[] args)
        {
            int correctCount = 0;

            Console.Write("Welcome to AlphaBits! The goall of this admittedly lame game  is to type all of the letters of the alphabet (in any order)  without hitting any non-letter characters \n");

            //type "hint" for a hint;
            AlphaList userList = new AlphaList();

            while (correctCount != 26)
            {
                

                Console.Write("You have currently typed {0} members of the alphabet. Type one!\n", correctCount);

                string input = Console.ReadLine();

                if(input.Length != 1)
                {
                    Console.Write("Please enter exactly one letter. If you enter more than one letter, only the first letter will count. \n");
                }

                if(input == "!")
                {

                    String charString = userList.returnList();
                    Console.Write("Current userList is {0} \n", charString);
                }

                char inputChar = input[0];

                userList.addChar(inputChar);

                correctCount = userList.listLength();

            }

            Console.WriteLine("Congratulations!You typed all the letters!");
            Console.ReadLine();
        }
    }
}
