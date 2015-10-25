/*
 * File:	    SwordBehaviour.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    SwordBehaviour, IFightBehaviour
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
    class SwordBehaviour : IFightBehaviour
    {
        public Object UseWeapon()
        {
            return ("Fighting with a Sword!!");
        }
    }
}
