using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem
{
	public class Plant : IGrowable
	{
		public void Grow()
		{
            Console.WriteLine("The plant grew to be 10 meters tall");
        }
	}
}
