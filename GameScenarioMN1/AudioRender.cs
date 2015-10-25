/*
 * File:	    AudioRender.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	11/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    AudioRender, CharacterRender, Character
 * Requires:	
 * 
 * Description:
 * 
 * Concrete class for the decorator pattern used to provide augmented
 * behaviour - audio rendering of the game characters.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public class AudioRender : CharacterRender
    {
        public AudioRender(Character c)
            : base(c)
        {
        }

        public override String DisplayRender()
        {
            // provide the audio rendering in this method
            return character.DisplayRender() + "\n\t Audio Rendering";
        }
    }
}
