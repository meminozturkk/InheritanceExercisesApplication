using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem
{
	public sealed class Lion : Mammal
	{
	
		public override void Eat()
		{
            Console.WriteLine("The lion eats meat");
        }
		public override void Breed()
		{
            Console.WriteLine("Six lion cubs produced");
        }

		public override void Grow()
		{
            Console.WriteLine("The lion grew to be 400 kgs");
        }
	}
}
