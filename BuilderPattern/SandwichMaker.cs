using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SandwichMaker
    {
        private SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            this.builder = sandwichBuilder;
        }

        private void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            BuildSandwich();
            return builder.GetSandwich();
        }
    }
}
