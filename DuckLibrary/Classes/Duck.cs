using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckLibrary
{
    public abstract class Duck
    {
        protected Flyable flyBehavior;
        protected Quackable quackBehavior;

        public string Swim()
        {
            return "Буль, буль, буль";
        }
        public string Display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
        public string RunQuack()
        {
            return quackBehavior.Quack();
        }
        public string RunFly()
        {
            return flyBehavior.Fly();
        }

        public void SetQuackBehavir(Quackable quack)
        {
            quackBehavior = quack;
        }

        public void SetFlyBehavior(Flyable fly)
        {
            flyBehavior = fly;
        }
    }
}
