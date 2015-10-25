/*
 * File:	    Orc.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    Orc, Character, IFightBehaviour
 * Requires:	
 * 
 * Description:
 * 
 * This class is the initial status of the Orc
 * character for all Orcs. Providing initial values
 * for the inherited attributes from the Character class.
 * 
 */


namespace GameScenarioMN1
{
    class Orc : Character
    {
        // method for creating the Orc Class
        public Orc()
        {
            Name = "Orc";
            Strength = 17;
            Health = 18;
            FightBehaviour = new ClubBehaviour();
        }
    }
}
