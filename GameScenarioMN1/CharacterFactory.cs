/*
 * File:	    CharacterFactory.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    CharacterFactory
 * Requires:	charactertype
 * 
 * Description:
 * 
 * This file is where the selection of the character is used to
 * create an instance of the character required by the CharacterStore
 * using the Factory Method Design Pattern.
 * 
 * If a new type (class) of character is to be introduced to the game
 * this is the only file that requires altering to allow creation of 
 * a new concrete character. In addition to creating the new character
 * class file.
 * 
 */


namespace GameScenarioMN1
{
    class CharacterFactory
    {
        // to create a new character
        // add the new class name to the enum of charactertypes
        // add an else if statement to the CreateCharacter method
        // create your new character class

        public enum charactertype
        {
            orc,
            sorcerer,
            townperson,
            warrior,
        }

        public Character CreateCharacter(charactertype type)
        {
            Character character = null;

            if (type.Equals(charactertype.orc)) {
                character = new Orc();
            }
            else if (type.Equals(charactertype.sorcerer)) {
                character = new Sorcerer();
            }
            else if (type.Equals(charactertype.townperson)) {
                character = new TownPerson();
            }
            else if (type.Equals(charactertype.warrior)) {
                character = new Warrior();
            }
            return character;
        }
    }
}
