﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitites;

namespace OOP
{
    internal class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
            };

            
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
