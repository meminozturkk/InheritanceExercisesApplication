using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem
{
	public class Moose : Deer
	{
		public override void Grow()
		{
            Console.WriteLine("The moose grew to be 700 kgs");
        }
	}
}
