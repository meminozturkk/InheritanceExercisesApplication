using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem
{
    public abstract class Animal : IGrowable
    {
        public abstract void Eat();
        public abstract void Breed();
        public abstract void Grow();
	}
}
