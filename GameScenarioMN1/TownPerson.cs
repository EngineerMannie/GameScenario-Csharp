/*
 * File:	    TownPerson.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    TownPerson, Character, IFightBehaviour
 * Requires:	
 * 
 * Description:
 * 
 * This class is the initial status of the TownPerson
 * character for all TownPersons. Providing initial values
 * for the inherited attributes from the Character class.
 * 
 */


namespace GameScenarioMN1
{
    class TownPerson : Character
    {
        // method for creating the TownPerson Class
        public TownPerson()
        {
            Name = "TownPerson";
            Strength = 11;
            Health = 12;
            FightBehaviour = new ClubBehaviour();
        }
    }
}
