using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
     public void fly()
     {
         Console.WriteLine("There is no way a duck can fly without wings");
     }
    }
}