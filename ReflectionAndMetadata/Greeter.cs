﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ReflectionAndMetadata
{

    internal partial class Greeter
    {
        static public void Greet(string name)
        {
            GeneratedGreet(name);
        }
        static partial void GeneratedGreet(string name);

    }

}
