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
    class TransformComponent : Component
    {
        public float rotation {get; set;}
        public Vector2 position { get; set; }

        public TransformComponent(Vector2 givenPosition, float givenRotation)
        {
            position = givenPosition;
            rotation = givenRotation;
        }
    }
}
