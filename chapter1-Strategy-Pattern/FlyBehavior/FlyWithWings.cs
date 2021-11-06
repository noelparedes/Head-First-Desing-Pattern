using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.FlyBehavior
{
    public class FlyWithWings:IFlyBehavior
    {
      
      public void fly()
      {
          Console.WriteLine("I'm the best at flying");
      }
        
    }
}