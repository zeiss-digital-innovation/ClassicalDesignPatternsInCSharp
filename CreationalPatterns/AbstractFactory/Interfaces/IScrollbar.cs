using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Interfaces
{
    public interface IScrollbar
    {
        uint Width{ get; set; }
        Color BackgroundColor { get; set; }
    }
}
