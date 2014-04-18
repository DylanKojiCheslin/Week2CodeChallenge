using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{

    class Program
    {
        /// <summary>
        /// tells you FizzBuzz if input is divisable by 5 and 3, tells you Fizz if divisable by 5, Buzz if divisble by 3
        /// </summary>
        /// <param name="x">int x</param>
        static void FizzBuzz(int x)
        {
            if (x % 5 == 0 && x % 3 == 0)//true if divisable by 5 and 3
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (x%5==0)//true if divisable by 5
            {
                Console.WriteLine("Fizz");
            }
            else if (x % 3 == 0)//true if divisable by 3
            {
                Console.WriteLine("FizzBuzz");
            }
            else//prints x
            {
                Console.WriteLine(x);
            }
        }
/// <summary>
/// this tells you how often a char is in a string
/// </summary>
/// <param name="letter">how many of</param>
/// <param name="inString">are in this string</param>
        static void LetterCounter(char letter, string inString)
        {
            int numLowerCase = 0;//counts amount of lower case of choosen char
            int numUpperCase = 0;//counts amount of upper case of choosen char
            for (int i = 0; i < inString.Length; i++)//loops through instring
            {
                if (inString[i] ==  char.ToLower(letter))//finds and records lower case char
                {
                    numLowerCase++;
                }
                else if (inString[i] == char.ToUpper(letter))//finds and records upper case char
                {
                    numUpperCase++;
                }
            }
            Console.WriteLine("Input "+inString);//output
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + numLowerCase);//output
            Console.WriteLine("Number of upercase " + letter + "'s found: " + numUpperCase);//output
            Console.WriteLine("Total Number of " + letter + "'s found " + (numLowerCase + numUpperCase));//output
        }
        /// <summary>
        /// takes a string input and prints the number of chars, number of words, vowels, number of consonants, number of speccial chars, the longest and shortest word
        /// </summary>
        /// <param name="input">string that you want to know about</param>
        static void TextStats(string input)
        {
            int numVowels = 0;
            int numConsonats = 0;
            int numOther = 0;
            int numWords = 0;
            string[] words = input.Split(' ');
            string longestWord="";
            string shortestWord="";
            for (int i = 0; i < input.Length; i++)
            {   //increase count of vowels
                if (input[i] == 'b' || input[i] == 'c' || input[i] == 'd' || input[i] == 'f' || input[i] == 'g' || input[i] == 'h' || input[i] == 'j' || input[i] == 'k' || input[i] == 'l' || input[i] == 'm' || input[i] == 'n' || input[i] == 'p' || input[i] == 'q' || input[i] == 'r' || input[i] == 's' || input[i] == 't' || input[i] == 'v' || input[i] == 'w' || input[i] == 'x' || input[i] == 'z')
                {
                    numVowels++;
                }
                //increase count of  consonats
                else if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                {
                    numConsonats++;
                }
                else if (input[i] == ' ')
                //increase num of words
                {
                    numWords++;
                }
                //increase num of other charicters
                else
                {
                    numOther++;
                }
                longestWord = words[0];//sets longest word to first value in words
                shortestWord = words[0];//sets shortest word to first value in words
                for (int x = 0; x < words.Length; x++)//loops through all words
                {
                    string thisword = words[x];//local var for comparisons
                    if (thisword.Length > longestWord.Length)//is this word the longest
                    {
                        longestWord = thisword;//make it the longest
                    }
                    if (thisword.Length < shortestWord.Length )//is this word the shortest
                    {
                        shortestWord = thisword;//make it the shortest
                    }
                }
            }
            Console.WriteLine("number of caricters in input " + input.Length);//write number of caricters in input
            Console.WriteLine("number of words num " + numWords);//write number of words
            Console.WriteLine("number of vowels " + numVowels);//write number of Vowels
            Console.WriteLine("number of consonats " + numConsonats);//write number of Consonats
            Console.WriteLine("number of special charicters " + numOther);//write number of words
            Console.WriteLine("longest word "+ longestWord);//write longest word
            Console.WriteLine("shortest word "+ shortestWord);//write shortest word
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                FizzBuzz(i);
            }
            LetterCounter('i',"I love biscuits and gravy. Its's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            TextStats("Don't talk, Do.");
        }
    }
}
