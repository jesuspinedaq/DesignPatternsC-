using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class MyPoliceTape : ITapeCasette
    {
        public string Album
        {
            get
            {
                return "Outlandos d'amour";
            }
        }

        public string Artist
        {
            get
            {
                return "The Police"; 
            }
        }
    }
}
