using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class MuteQuack:IQuackBehavior
    {
      public void quack()
      {
          Console.WriteLine("These kinds of duck are silence");
      }
    }
}