using System;
using System.Collections.Generic;
using System.Text;
using ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Interfaces;

namespace ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Implementations
{
    public class MotifWindow : IWindow
    {
        public uint Hight { get; set; }
        public uint Width { get; set; }
    }
}
