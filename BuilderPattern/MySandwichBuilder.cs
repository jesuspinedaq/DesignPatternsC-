using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.hasMustard = true;
            sandwich.hasMayo = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string>();
            sandwich.vegetables.Add("Tomatoe");
            sandwich.vegetables.Add("Lettuce");
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.chesseType = ChesseType.Provolone;
            sandwich.meatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            sandwich.breadType = BreadType.Wheat;
            sandwich.isToasted = true;
        }
    }
}
