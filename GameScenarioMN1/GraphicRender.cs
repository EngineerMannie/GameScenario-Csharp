/*
 * File:	    GraphicRender.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	11/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    GraphicRender, CharacterRender, Character
 * Requires:	
 * 
 * Description:
 * 
 * Concrete class for the decorator pattern used to provide augmented
 * behaviour - graphical rendering of the game characters.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public class GraphicRender : CharacterRender
    {
        public GraphicRender(Character c) : base (c)
        {
        }

        public override String DisplayRender()
        {
            // provide the graphical rendering in this method
            return character.DisplayRender() + "\n\t Graphic Rendering";
        }
    }
}
