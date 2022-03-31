using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class MallardDuck:Duck
    {
        public MallardDuck()
        { 
           quackBehavior = new Quack();
           flyBehavior = new FlyWithWings();
        }
        public override void  display()
           {
              Console.WriteLine("I'm a real mallard duck");
           }
    }
}