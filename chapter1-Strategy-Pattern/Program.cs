using System;
using chapter1_Strategy_Pattern.Ducks;
using chapter1_Strategy_Pattern.FlyBehavior;

namespace chapter1_Strategy_Pattern
{
    class Program
    {
        static void Main()
        {
            Duck mallarDucks = new MallardDuck();
            mallarDucks.performFly();
            mallarDucks.performQuack();
            mallarDucks.swim();
            mallarDucks.display();
            Console.WriteLine("------------------");
           
            Duck model = new ModelDuck();
            model.performQuack();
            model.performFly();
            model.setFlyBehavior(new FlyWithRocketPower());
            model.performFly();
            model.swim();
            model.display();
            Console.WriteLine("------------------");

            Duck readheadDuck = new RedHeadDuck();
            readheadDuck.performQuack();
            readheadDuck.performFly();
            readheadDuck.swim();
            readheadDuck.display();

            
           
        
        }
    }
}
