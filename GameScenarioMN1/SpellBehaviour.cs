/*
 * File:	    SpellBehaviour.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    SpellBehaviour, IFightBehaviour
 * Requires:	
 * 
 * Description:
 * 
 * 
 * 
 */

using System;

namespace GameScenarioMN1
{
    class SpellBehaviour : IFightBehaviour
    {
        public Object UseWeapon()
        {
            // method for building fight behaviour
            return ("Casting fight Spells!!");
        }
    }
}
