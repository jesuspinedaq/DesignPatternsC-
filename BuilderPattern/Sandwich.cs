using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Sandwich
    {
        public BreadType breadType { get; set; }
        public bool isToasted { get; set; }
        public ChesseType chesseType { get; set; }
        public MeatType meatType { get; set; }
        public bool hasMustard { get; set; }
        public bool hasMayo { get; set; }
        public List<string> vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("Bread type:{0}", breadType);
            Console.WriteLine("Is toasted:{0}", isToasted);
            Console.WriteLine("Chesse type:{0}", chesseType);
            Console.WriteLine("Meat type:{0}", meatType);
            Console.WriteLine("Has mustard:{0}", hasMustard);
            Console.WriteLine("Has mayo:{0}", hasMayo);
            foreach (string vegetable in vegetables)
            {
                Console.WriteLine(vegetable);
            }
        }

    }
}
