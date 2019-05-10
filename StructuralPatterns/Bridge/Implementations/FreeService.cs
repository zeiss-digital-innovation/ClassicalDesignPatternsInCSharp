using System;
using System.Collections.Generic;
using System.Text;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Interfaces;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Implementations
{
    public class FreeService : IComponent
    {
        public Type Send(string message)
        {
            Console.WriteLine($"FreeService sends: {message}");
            return this.GetType();
        }
    }
}
