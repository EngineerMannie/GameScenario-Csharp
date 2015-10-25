/*
 * File:	    Program.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	29/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    Main
 * Requires:	
 * 
 * Description:
 * 
 * Test harness for the Fight Game Scenario.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace GameScenarioMN1
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a list for the 'new' characters
            List<Character> characters = new List<Character>();

            // create an instance of the CharacterFactory and link it
            // to the instance of the CharacterStore
            CharacterFactory factory = new CharacterFactory();
            CharacterStore myStore = new CharacterStore(factory);

            // create some characters and add them to the list of characters
            Character war1 = myStore.GetCharacter(CharacterFactory.charactertype.warrior);
            characters.Add(war1);
            Character orc1 = myStore.GetCharacter(CharacterFactory.charactertype.orc);
            characters.Add(orc1);
            Character tow1 = myStore.GetCharacter(CharacterFactory.charactertype.townperson);
            characters.Add(tow1);
            Character sor1 = myStore.GetCharacter(CharacterFactory.charactertype.sorcerer);
            characters.Add(sor1);
            Character war2 = myStore.GetCharacter(CharacterFactory.charactertype.warrior);
            characters.Add(war2);

            // print to screen the character list and their current attributes
            Console.WriteLine("<<<< START OF LIST >>>>\n");
            foreach (Character character in characters)
            {
                Console.WriteLine("Character List : {0} is a {1}\t Strength = {2}\t Health = {3}.\n\t\t\t{1} {4}\n",
                    characters.IndexOf(character), character.Name, character.Strength, 
                    character.Health, character.DoFighting());
            }
            Console.WriteLine("<<<< END OF INITIAL LIST >>>>\n");
            Console.WriteLine("<<<< ADJUST HEALTH AND STRENGTH >>>>\n");

            // test setting health and strength on the fly
            ChangeStrength(characters, orc1, -1);
            ChangeHealth(characters, orc1, 2);
            ChangeStrength(characters, war2, -3);

            foreach (Character character in characters)
            {
                Console.WriteLine("Character List : {0} is a {1}\t Strength = {2}\t Health = {3}.\n\t\t\t{1} {4}\n",
                    characters.IndexOf(character), character.Name, character.Strength,
                    character.Health, character.DoFighting());
            }
            Console.WriteLine("<<<< END OF CHANGES TEST >>>>\n");

            // test setting fight behaviour on the fly
            Console.WriteLine("<<<< FIGHT BEHAVIOUR CHANGES >>>>\n");

            characters.First(c => c.Equals(orc1)).FightBehaviour = new SwordBehaviour();
            PrintFightBehaviour(characters, orc1);
            characters.First(c => c.Equals(tow1)).FightBehaviour = new SwordBehaviour();
            PrintFightBehaviour(characters, tow1);
            characters.First(c => c.Equals(sor1)).FightBehaviour = new ClubBehaviour();
            PrintFightBehaviour(characters, sor1);
            characters.First(c => c.Equals(war1)).FightBehaviour = new ClubBehaviour();
            PrintFightBehaviour(characters, war1);
            characters.First(c => c.Equals(war2)).FightBehaviour = new ClubBehaviour();
            PrintFightBehaviour(characters, war2);

            Console.WriteLine("<<<< END OF FIGHT CHANGES >>>>\n");

            /* THIS NEEDS SOME WORK YET - CREATE THE SINGLETON CLASS
            // check link to external database stub in the list
            Console.WriteLine("<<<< START OF LIST DATABASE CONNECTION >>>>\n");
            foreach (Character char1 in characters)
            {
                Console.WriteLine("Character List : {0} is a {1}\n",
                    characters.IndexOf(char1), char1.GetInformation());
            }
            Console.WriteLine("<<<< END OF LIST DATABASE CONNECTION >>>>\n");
            */

            // test the character rendering classes
            Character char1 = characters.First(c => c.Equals(tow1));
            char1 = new TextRender(char1);
            char1 = new AudioRender(char1);
            char1 = new TextRender(char1);
            Console.WriteLine("Character {0} index {1}\n",
                characters[3].GetType(),
                characters[3].DisplayRender());

            foreach (Character chr in characters)
            {
                PrintCharacterRender(characters, chr);
            }

            Console.ReadKey();

        } // END OF MAIN METHOD



        private static void PrintCharacterRender(List<Character> characters, Character char1)
        {
            Console.WriteLine("Character {0} index {1} {2}\n",
                characters.First(c => c.Equals(char1)).Name,
                characters.IndexOf(characters.First(c => c.Equals(char1))),
                characters.First(c => c.Equals(char1)).DisplayRender());

        } // END OF PrintCharacterRender METHOD
            

        private static void PrintFightBehaviour(List<Character> characters, Character char1)
        {
            Console.WriteLine("Character {0}\nindex {1} {2}\n",
                characters.First(c => c.Equals(char1)).Name,
                characters.IndexOf(char1),
                characters.First(c => c.Equals(char1)).DoFighting());

        } // END OF PrintFightBehaviour METHOD


        private static void ChangeHealth(List<Character> characters, Character char1, int dHealth)
        {
            int currentHealth = characters.FirstOrDefault(c => c.Equals(char1)).Health;
            characters.FirstOrDefault(c => c.Equals(char1)).Health = currentHealth + dHealth;

            Console.WriteLine("Character Health ({0}) for {1} index {2} = {3}\n",
                dHealth,
                characters.FirstOrDefault(c => c.Equals(char1)).Name,
                characters.IndexOf(char1),
                characters.FirstOrDefault(c => c.Equals(char1)).Health);

        } // END OF ChangeHealth METHOD


        private static void ChangeStrength(List<Character> characters, Character char1, int dStrength)
        {   
            int currentStrength = characters.FirstOrDefault(c => c.Equals(char1)).Strength;
            characters.FirstOrDefault(c => c.Equals(char1)).Strength = currentStrength + dStrength;

            Console.WriteLine("Character Strength ({0}) for {1} index {2} = {3}\n",
                dStrength,
                characters.FirstOrDefault(c => c.Equals(char1)).Name,
                characters.IndexOf(char1),
                characters.FirstOrDefault(c => c.Equals(char1)).Strength);

        } // END OF ChangeStrength METHOD
    } // END OF CLASS
} // END OF NAMESPACE
