using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5DecoratorPattern
{
    class Program
    {
        static IComponent component;
        static void Main(string[] args)
        {
            component = new DecoratorComponent(new ConcreteComponent());
            component.Something();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
