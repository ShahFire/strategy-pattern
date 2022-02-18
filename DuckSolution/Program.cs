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
            Duck Bob = new MallardDuck();
            Duck Mac = new RedheadDuck();

            Duck[] ducks = { Bob, Mac };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Quack());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
            }

            Console.ReadKey();
        }
    }
}
