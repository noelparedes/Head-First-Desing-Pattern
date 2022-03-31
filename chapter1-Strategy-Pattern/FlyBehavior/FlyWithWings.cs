using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class FlyWithWings:IFlyBehavior
    {
      
      public void fly()
      {
          Console.WriteLine("I'm the best at flying");
      }
        
    }
}