using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new IocContainer();
            container.Register<SonyWaltman, SonyWaltman>();
            container.Register<ITapeCasette, MyPoliceTape>();

            var waltman = container.Resolve<SonyWaltman>();

            Console.WriteLine(waltman.Play());
            Console.ReadKey();
        }
    }
}
