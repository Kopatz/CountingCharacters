using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string msg = "racecar racecar";
            // iterate through string, initialize characters in dictionary 
            foreach (char letter in msg.ToCharArray()){
                if (characters.ContainsKey(letter))
                {
                    characters[letter] += 1;
                }
                else
                {
                    characters.Add(letter, 1);
                }      
             }// end foreach
            foreach(KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }

        }

        }
    }

