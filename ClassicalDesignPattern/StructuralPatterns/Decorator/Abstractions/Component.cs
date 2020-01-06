using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Abstractions
{
    public abstract class Component
    {
        internal string Name => "Pizza";

        public abstract string Cook();
    }
}
