using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Abstractions;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator
{
    public abstract class DecoratorBase : Component
    {
        internal Component Component { get; set; }
        public DecoratorBase(Component component)
        {
            Component = component;
        }
    }
}
