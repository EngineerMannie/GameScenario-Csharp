/*
 * File:	    Warrior.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    Warrior, Character, IFightBehaviour
 * Requires:	
 * 
 * Description:
 * 
 * This class is the initial status of the Warrior
 * character for all Warriors. Providing initial values
 * for the inherited attributes from the Character class.
 * 
 */


namespace GameScenarioMN1
{
    class Warrior : Character
    {
        // method for creating the Warrior Class
        public Warrior()
        {
            Name = "Warrior";
            Strength = 13;
            Health = 14;
            FightBehaviour = new SwordBehaviour();
        }

    }
}
