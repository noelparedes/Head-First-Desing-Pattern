using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
   public class FlyWithRocketPower : IFlyBehavior
    {
     public void fly()
     {
         Console.WriteLine("Flying with a rocket power!");
     }
    }
}