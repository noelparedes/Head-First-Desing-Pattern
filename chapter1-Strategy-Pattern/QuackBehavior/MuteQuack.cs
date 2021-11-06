using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.QuackBehavior
{
    public class MuteQuack:IQuackBehavior
    {
      public void quack()
      {
          Console.WriteLine("These kinds of duck are silence");
      }
    }
}