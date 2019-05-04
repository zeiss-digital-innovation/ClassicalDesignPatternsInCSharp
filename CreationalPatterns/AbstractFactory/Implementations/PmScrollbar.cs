using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Interfaces;

namespace ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Implementations
{
    public class PmScrollbar : IScrollbar
    {
        public uint Width { get; set; }
        public Color BackgroundColor { get; set; }
    }
}
