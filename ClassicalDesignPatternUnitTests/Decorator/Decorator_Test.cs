using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Abstractions;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Implementation;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Decorator.Implementation.Decorators;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicalDesignPatternUnitTests.Decorator
{
    [TestFixture]
    public class Decorator_Test
    {
        [SetUp]
        public void Setup(){}

        [Test]
        public void Create_Pizza()
        {
            var oven = new ConcreteComponent();
            var product = oven.Cook();

            Assert.AreEqual("Pizza", product);

        }

        [Test]
        public void Create_Hot_Pizza()
        {
            var oven = new DecoratorOne(new ConcreteComponent());
            Assert.AreEqual("Hot Pizza", oven.Cook());
        }

        [Test]
        public void Create_Spicy_Pizza()
        {
            var oven = new DecoratorTwo(new ConcreteComponent());
            Assert.AreEqual("Spicy Pizza", oven.Cook());
        }

        [Test]
        public void Create_Hot_Spicy_Pizza()
        {
            var oven = new DecoratorOne(new DecoratorTwo(new ConcreteComponent()));
            Assert.AreEqual("Hot Spicy Pizza", oven.Cook());
        }

        [Test]
        public void Create_Hot_Spicy_Pizza_As_Base()
        {
            Component oven = new DecoratorOne(new DecoratorTwo(new ConcreteComponent()));
            Assert.IsInstanceOf<Component>(oven);
            Assert.IsInstanceOf<DecoratorBase>(oven);
            Assert.AreEqual("Hot Spicy Pizza", oven.Cook());
        }

    }
}
