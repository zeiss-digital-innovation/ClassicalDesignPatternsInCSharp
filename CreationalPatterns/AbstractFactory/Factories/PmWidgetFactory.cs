using System;
using System.Collections.Generic;
using System.Text;
using ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Implementations;
using ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Interfaces;

namespace ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Factories
{
    public class PmWidgetFactory : IWidgetFactory
    {
        public IScrollbar CreateScrollbar()
        {
            return new PmScrollbar();
        }

        public IWindow CreateWindow()
        {
            return new PmWindow();
        }
    }
}
