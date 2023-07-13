using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem
{
	public class Deer : Mammal
	{
		public override void Eat()
		{
            Console.WriteLine("The deer eats weed");
        }
		public override void Grow()
		{
            Console.WriteLine("The deer grew to be 80 kgs");
        }

	}
}
