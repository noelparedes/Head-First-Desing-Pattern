using System;
using chapter1_Strategy_Pattern.Interfaces;

namespace chapter1_Strategy_Pattern.QuackBehavior
{
    public class Squeak:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Duck can squeak....");
        }
    }
}