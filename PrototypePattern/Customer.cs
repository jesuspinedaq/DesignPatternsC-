using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Customer:ICloneable    
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name} - {Department}";
        }
    }
}
