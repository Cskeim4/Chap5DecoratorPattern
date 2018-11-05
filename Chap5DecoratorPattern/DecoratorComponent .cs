using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5DecoratorPattern
{
    class DecoratorComponent : IComponent
    {
        // store the component to use locally
        private readonly IComponent decoratedComponent;

        // constructor that is passed a component to use
        public DecoratorComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }

        public void Something()
        {
            SomethingElse();                    // add functionality localy to the component
            decoratedComponent.Something();     // call something in the component
        }

        private void SomethingElse()
        {
            Console.WriteLine("We are doing something else, also.");
        }

    }
}
