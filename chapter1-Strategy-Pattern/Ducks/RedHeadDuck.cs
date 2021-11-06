using System;
using chapter1_Strategy_Pattern.FlyBehavior;
using chapter1_Strategy_Pattern.QuackBehavior;

namespace chapter1_Strategy_Pattern.Ducks
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