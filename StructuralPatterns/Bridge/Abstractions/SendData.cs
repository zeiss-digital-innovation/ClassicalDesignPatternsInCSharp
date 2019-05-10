using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Interfaces;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Abstractions
{
    public abstract class DataSender
    {
        public IComponent Component { protected get; set; }
        public abstract Type Send(string message);
    }
}
