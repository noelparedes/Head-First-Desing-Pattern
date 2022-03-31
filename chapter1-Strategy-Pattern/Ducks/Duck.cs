using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {

        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;


        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();

        }
        public abstract void display();


        public void swim()
        {
            Console.WriteLine("All ducks can swim");
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }
}