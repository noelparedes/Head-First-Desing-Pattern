using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.QuackBehavior
{
    public class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Duck is quacking....");
        }

    }
}