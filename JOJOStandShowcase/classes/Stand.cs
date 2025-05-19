using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJOStandShowcase
{
    public abstract class Stand
    {
        protected string Name { get; }
        protected string Description { get; }
        protected string User { get; }
        protected char Power { get; }
        protected char Speed { get; }
        protected char Range { get; }
    }
}
