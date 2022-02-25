using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckLibrary;

namespace DuckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck Mark = new MallardDuck();
            Duck Riley = new RedheadDuck();
            Duck Ruby = new RubberDuck();
            Duck Devid = new DecoyDuck();

            Flyable flywithwings = new FlyWithWings();
            Quackable quackings = new DQuack();

            Ruby.SetFlyBehavior(flywithwings);
            Ruby.SetQuackBehavir(quackings);

            Duck[] ducks = { Mark, Riley, Ruby, Devid };


            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].RunFly());
                Console.WriteLine(ducks[i].RunQuack());
                Console.WriteLine("\n");
            }


            Console.ReadKey();
        }
    }
}
