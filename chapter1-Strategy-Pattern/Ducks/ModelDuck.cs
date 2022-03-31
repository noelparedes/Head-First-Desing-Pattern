using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.Interfaces;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new  FlyNoWay(); 
            quackBehavior = new MuteQuack();
      

        }
     
            public override void display()
        {
            Console.WriteLine("I'm a ModelDuck");
        }
                
            
    }
}