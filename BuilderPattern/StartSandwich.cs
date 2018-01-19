using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class StartSandwich
    {
        public BreadType breadType;
        public bool isToasted;
        public ChesseType chesseType;
        public MeatType meatType;
        public bool hasMustard;
        public bool hasMayo;
        public List<string> vegetables;

        public StartSandwich(BreadType breadType, bool isToasted, ChesseType chesseType, MeatType meatType, bool hasMustard, bool hasMayo, List<string> vegetables)
        {
            this.breadType = breadType;
            this.isToasted = isToasted;
            this.chesseType = chesseType;
            this.meatType = meatType;
            this.hasMustard = hasMustard;
            this.hasMayo = hasMayo;
            this.vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine("Bread type:{0}", breadType);
            Console.WriteLine("Is toasted:{0}", isToasted);
            Console.WriteLine("Chesse type:{0}", chesseType);
            Console.WriteLine("Meat type:{0}", meatType);
            Console.WriteLine("Has mustard:{0}", hasMustard);
            Console.WriteLine("Has mayo:{0}", hasMayo);
            foreach(string vegetable in vegetables)
            {
                Console.WriteLine(vegetable);
            }
        }
    }
}
