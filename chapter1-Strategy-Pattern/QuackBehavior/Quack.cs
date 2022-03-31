using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class Quack:IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Duck is quacking....");
        }

    }
}