using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5DecoratorPattern
{
    class ConcreteComponent : IComponent
    {
        public void Something()
        {
            Console.WriteLine("We are doing something!");
        }
    }
}

