using System;
using chapter1_Strategy_Pattern.FlyBehavior;
using chapter1_Strategy_Pattern.QuackBehavior;

namespace chapter1_Strategy_Pattern.Ducks
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