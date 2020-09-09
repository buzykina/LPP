﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LPP.Nodes
{
    public class Leaf : Node
    {
        public Leaf(char value) : base(null, null)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
