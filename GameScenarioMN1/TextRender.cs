/*
 * File:	    TextRender.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	10/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    TextRender, CharacterRender, Character
 * Requires:	
 * 
 * Description:
 * 
 * Concrete Base class for the decorator pattern used to provide
 * rendering of the game characters. i.e. The characters 
 * will always have text rendering providing character 
 * status information.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public class TextRender : CharacterRender
    {
        public TextRender(Character c) : base (c)
        {
        }

        public override String DisplayRender()
        {
            // provide the textual rendering in this method
            return character.DisplayRender() + "\n\t Text Rendering";
        }
    }
}
