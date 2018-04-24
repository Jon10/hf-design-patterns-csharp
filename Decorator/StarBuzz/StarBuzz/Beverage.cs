using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    abstract class Beverage
    {
        private string _description = "Unknown Beverage";

        public string Description { get => _description; set => _description = value; }

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return _description;
        }
    }
}
