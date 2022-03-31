using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
     public void fly()
     {
         Console.WriteLine("There is no way a duck can fly without wings");
     }
    }
}