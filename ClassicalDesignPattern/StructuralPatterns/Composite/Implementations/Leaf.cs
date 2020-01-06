using ClassicalDesignPatternsInCSharp.StructuralPatterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Composite.Implementations
{
    public class Leaf : IComponent
    {
        public IEnumerable<IComponent> Components => throw new NotSupportedException("Leafs do not suppoert subcomponents");

        public IComponent Parent { get; set; }
      
        public void AddComponent(IComponent component)
        {
            throw new NotSupportedException("Leafs do not suppoert subcomponents");
        }

        public void RemoveComponent(IComponent component)
        {
            throw new NotSupportedException("Leafs do not suppoert subcomponents");
        }
    }
}
