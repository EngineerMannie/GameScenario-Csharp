/*
 * File:	    OtherRender.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	11/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    OtherRender, CharacterRender, Character
 * Requires:	
 * 
 * Description:
 * 
 * Concrete class for the decorator pattern used to provide augmented
 * behaviour - other rendering of the game characters.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public class OtherRender : CharacterRender
    {
        public OtherRender(Character c)
            : base(c)
        {
        }

        public override String DisplayRender()
        {
            // provide the other rendering in this method
            return character.DisplayRender() + "\n\t Other Rendering";
        }
    }
}
