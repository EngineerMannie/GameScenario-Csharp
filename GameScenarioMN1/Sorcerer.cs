/*
 * File:	    Sorcerer.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    Sorcerer, Character, IFightBehaviour
 * Requires:	
 * 
 * Description:
 * 
 * This class is the initial status of the Sorcerer
 * character for all Sorcerers. Providing initial values
 * for the inherited attributes from the Character class.
 * 
 */


namespace GameScenarioMN1
{
    class Sorcerer : Character
    {
        // method for creating the Sorcerer Class
        public Sorcerer()
        {
            Name = "Sorcerer";
            Strength = 15;
            Health = 16;
            FightBehaviour = new SpellBehaviour();
        }
    }
}
