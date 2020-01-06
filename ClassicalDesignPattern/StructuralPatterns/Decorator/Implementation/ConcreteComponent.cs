using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Implementation
{
    public class ConcreteComponent : Component
    {
        public override string Cook()
        {
            return Name;
        }
    }
}
