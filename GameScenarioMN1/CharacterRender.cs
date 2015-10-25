/*
 * File:	    CharacterRender.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	10/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    CharacterRender, Character
 * Requires:	
 * 
 * Description:
 * 
 * The abstract class to the Decorator Design Pattern used
 * to provide the rendering options of the game characters.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public abstract class CharacterRender : Character
    {
        // reference to wrapped object.
        protected Character character;

        // constructor method
        public CharacterRender(Character c)
        {
            this.character = c;
        }

        // forces render class methods to override this.
        public abstract override String DisplayRender();

    }
}
