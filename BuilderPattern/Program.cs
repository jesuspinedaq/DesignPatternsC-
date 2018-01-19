using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMaker maker = new SandwichMaker(new MySandwichBuilder());
            //maker.BuildSandwich();
            var sandwich1 = maker.GetSandwich();
            sandwich1.Display();

            SandwichMaker maker2 = new SandwichMaker(new MySandwichBuilder());
            //maker2.BuildSandwich();
            var sandwich2 = maker2.GetSandwich();
            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
