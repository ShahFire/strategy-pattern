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

            Duck[] ducks = { Mark, Riley, Ruby, Devid };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
                if (ducks[i] is Quackable)
                {
                    Console.WriteLine((ducks[i] as Quackable).Quack());
                }

                if (ducks[i] is Flyable)
                {
                    Console.WriteLine((ducks[i] as Flyable).Fly());
                }

            }

            Console.ReadKey();
        }
    }
}
