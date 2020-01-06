using System;
using System.Collections.Generic;
using System.Text;
using ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Abstractions;

namespace ClassicalDesignPatternsInCSharp.StructuralPatterns.Bridge.Implementations
{
    public class SendMail : DataSender
    {
        public override Type Send(string message)
        {
            return Component.Send($"{message} - sent via Mail");
        }
    }
}
