using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Implementation.Decorators
{
    public class DecoratorOne : DecoratorBase
    {
        public DecoratorOne(Component component) : base(component){}

        public override string Cook()
        {
            // add additional functionality to the DoSomething method
            // do it before calling the original behaviour
            var name = Component.Cook();

            // or afterwards
            return "Hot " + name;
        }
    }
}
