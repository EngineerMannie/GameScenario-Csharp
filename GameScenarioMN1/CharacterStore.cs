/*
 * File:	    CharacterStore.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    CharacterStore
 * Requires:	CharacterFactory.charactertype
 * 
 * Description:
 * 
 * The CharacterStore is used to get the required character
 * from the CharacterFactory using the Factory Method Design Pattern.
 * 
 * The CharacterStore allows any character to be created at runtime
 * using the same method in the main program.
 * 
 */


namespace GameScenarioMN1
{
    class CharacterStore
    {
        private CharacterFactory theFactory;

        public CharacterStore(CharacterFactory f)
        {
            theFactory = f;
        }

        public Character GetCharacter(CharacterFactory.charactertype type)
        {
            Character character = theFactory.CreateCharacter(type);
            return character;
        }
    }
}
