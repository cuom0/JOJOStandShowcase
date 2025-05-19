using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJOStandShowcase
{
    public abstract class Stand
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected string User { get; set; }
        protected char Power { get; set; }
        protected char Speed { get; set; }
        protected char Range { get; set; }
        protected char Stamina { get; set; }
        protected char Precision { get; set; }
        protected char Potential { get; set; }
    }
}
