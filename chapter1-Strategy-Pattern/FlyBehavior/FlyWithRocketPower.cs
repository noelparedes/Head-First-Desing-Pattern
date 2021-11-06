using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.FlyBehavior
{
   public class FlyWithRocketPower : IFlyBehavior
    {
     public void fly()
     {
         Console.WriteLine("Flying with a rocket power!");
     }
    }
}