using System;
using chapter1_Strategy_Pattern.FlyBehavior;
using chapter1_Strategy_Pattern.Interfaces;
using chapter1_Strategy_Pattern.QuackBehavior;

namespace chapter1_Strategy_Pattern.Ducks
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