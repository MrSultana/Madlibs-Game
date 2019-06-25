using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            string theMatrix, system, neo, enemy = "", inside = "", save = "", unplugged = "", fight = "";
            string[] profession = new string[4], adj = new string[2];

            // Get Input From User
            Console.WriteLine("Welcome, player!");
            Console.WriteLine("Lets play a game of madlibs!");
            Console.WriteLine("Please share with me your name");
            // Gets neo variable from user
            neo = Console.ReadLine();

            // Gets theMatrix variable from user
            Console.WriteLine($"Hello {neo}! Are you ready? What is something you " +
                $"want to know more about?"); 
            theMatrix = Console.ReadLine();

            // Gets system variable from user
            Console.WriteLine($"So, you want to know more about {theMatrix}?");
            Console.WriteLine($"Okay, well first tell me what you already know about {theMatrix}.");
            Console.WriteLine($"What noun would you categorise {theMatrix} as?"); 
            system = Console.ReadLine();

            // Gets enemy variable from user
            Console.WriteLine($"Give me an opposing noun to {system}.");
            enemy = Console.ReadLine();

            // Gets inside variable from user
            Console.WriteLine($"Now give me a noun to describe where someone is (present tense).");
            inside = Console.ReadLine();

            // Gets user to define each of the four professions needed
            Console.WriteLine($"Ok, now I need four professsion relating to {system}.");
            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"Profession (plural) {i + 1} / {profession.Length}.");
                profession[i] = Console.ReadLine();
            }

            // Gets user to define the save variable
            Console.WriteLine("Okay, time to get the rest of the words.");
            Console.WriteLine("Please give me a verb relating to the people in these professions.");
            save = Console.ReadLine();

            // Gets the user to define the unplugged variable
            Console.WriteLine("Give me an adjective, that describes what the people in these professions do not want to be.");
            unplugged = Console.ReadLine();

            // Gets user to define the two adjectives in the array
            Console.WriteLine("Okay, now im going to get you to give me two adjectives.");
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"Adjective (plural) {i + 1} / {adj.Length}.");
                adj[i] = Console.ReadLine();
            }

            // Gets user to define the fight variable
            Console.WriteLine("Okay, just one more word.");
            Console.WriteLine($"What would the people in the professions do to the protect {theMatrix}?");
            Console.ReadLine();

            // End Message
            Console.WriteLine("Now you're done! Lets print the completed story, shall we?");

           
            // Init Story
            string madlibsStory =
            $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}." +
            $"But when you're {inside}, you look around, what do you see?" +
            $"{profession[0]}'s, {profession[1]}'s, {profession[2]}'s, {profession[3]}'s. The very minds of " +
            $"the people we are trying to {save}. But until we do, " +
            $"these people are still a part of that {system} and that makes " +
            $"them our {enemy}. You have to understand, most of these people " +
            $"are not ready to be {unplugged}. And many of them are so {adj[0]}, " +
            $"so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.";

            // Print Story
            Console.WriteLine(madlibsStory);
            Console.ReadKey();
        }
    }
}
