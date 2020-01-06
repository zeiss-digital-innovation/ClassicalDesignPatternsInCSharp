using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Interfaces
{
    public interface IComponent
    {
        Type Send(string message);
    }
}
