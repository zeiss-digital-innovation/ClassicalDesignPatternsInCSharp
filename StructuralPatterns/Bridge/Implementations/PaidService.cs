using System;
using System.Collections.Generic;
using System.Text;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Interfaces;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Implementations
{
    public class PaidService : IComponent
    {
        public Type Send(string message)
        {
            Console.WriteLine($"PaidService sends: {message}");
            return GetType();
        }
    }
}
