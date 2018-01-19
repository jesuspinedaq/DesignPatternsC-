using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class MyGenesisTape : ITapeCasette
    {
        public string Album
        {
            get
            {
                return "Genesis";
            }
        }

        public string Artist
        {
            get
            {
                return "Selling England by the pound";
            }
        }
    }
}
