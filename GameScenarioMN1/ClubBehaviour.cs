/*
 * File:	    ClubBehaviour.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	09/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    ClubBehaviour, IFightBehaviour
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
    class ClubBehaviour : IFightBehaviour
    {
        public Object UseWeapon()
        {
            return ("Clubbing with a Club!!");
        }
    }
}
