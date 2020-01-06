using ClassicalDesignPatternsInCSharp.StructuralPatterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Composite.Implementations
{
    public class Composision : IComponent
    {
        public IEnumerable<IComponent> Components { get; private set; }

        public IComponent Parent { get; set; }

        public void AddComponent(IComponent component)
        {
            if (component == null)
                throw new ArgumentNullException("component must not be null");

            if (Components == null)
                Components = new List<IComponent>();

            component.Parent = this;
            (Components as List<IComponent>)?.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            if (Components == null || component ==  null)
                return;

            (Components as List<IComponent>)?.Remove(component);
        }
    }
}
