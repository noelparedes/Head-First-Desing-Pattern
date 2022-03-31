using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class RedHeadDuck:Duck
    {
        public RedHeadDuck()
        {
         flyBehavior = new FlyWithWings();
         quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a read duck");
        }
    }
}