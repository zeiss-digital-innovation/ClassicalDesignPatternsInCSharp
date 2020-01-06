using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Composite.Interfaces
{
    public interface IComponent
    {

        IEnumerable<IComponent> Components { get; }

        IComponent Parent { get; set; }

        void AddComponent(IComponent component);

        void RemoveComponent(IComponent component);
    }
}
