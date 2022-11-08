using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5DecoratorPattern
{
    class Program
    {
        static IComponent originalComponent, decoratorComponent;

        static void Main(string[] args)
        {
            originalComponent = new ConcreteComponent();
            decoratorComponent = new DecoratorComponent(originalComponent);
            decoratorComponent.Something();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
