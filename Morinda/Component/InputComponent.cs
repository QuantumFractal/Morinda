﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion


namespace Morinda
{
    class InputComponent : Component
    {
        public Keys[] keysPressed;
        public Dictionary<Keys, Command> keyMap;

        public InputComponent(Dictionary<Keys, Command> givenKeyMap)
        {
            keyMap = givenKeyMap;

            //TODO put specific sources of input in this component. 
            //The keys structure is the choke point for control!
        }
    }
}
