using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class Squeak:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Duck can squeak....");
        }
    }
}