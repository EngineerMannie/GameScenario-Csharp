/*
 * File:	    Character.cs
 * Author:	    Martin Naismith
 * Student ID:  1304494
 * Version:	    1.0
 * Rev Date:	11/05/2014
 * 
 * Namespace:	GameScenarioMN1
 * Exposes:	    Character
 * Requires:	
 * 
 * Description:
 * 
 * This file defines the character attributes for all characters
 * giving access to them through public properties. It also provides
 * a link to the external data store for the characters.
 * 
 * This class is abstract.
 * 
 */

using System;

namespace GameScenarioMN1
{
    public abstract class Character
    {
        // members for all the characters

        protected String mName;
        public String Name { get { return mName; } set { mName = value; } }
        
        protected int mStrength;
        public int Strength { get { return mStrength; } set { mStrength = value; } }
        
        protected int mHealth;
        public int Health { get { return mHealth; } set { mHealth = value; } }
        
        protected IFightBehaviour mFightBehaviour;
        public IFightBehaviour FightBehaviour 
        { set { mFightBehaviour = value; } }

        protected String mRender = "Rendering - ";

        // end of members

        // methods for all the characters to external data store

        // returns current setting on mFightBehaviour
        // provided by implementing the Strategy Design Pattern
        public Object DoFighting()
        {
            return mFightBehaviour.UseWeapon();
        }

        // use this method to access external database
        // provided by implementing the Singleton Design Pattern
        public String GetInformation()
        {
            // create information for checking stub
            String characterInfo = this.ToString();
            return characterInfo;
        }

        // returns the render methods used for the character
        // provided by implementing the Decorator Design Pattern
        public virtual String DisplayRender()
        {
            return mRender;
        }

        // end of methods
    }
}
