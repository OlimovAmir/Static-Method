using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class Counter
    {
        public Counter()
        {
            counter++;
        }
        private static int counter;

		public static int CounterProperty
		{
			get { return counter; }
			set { counter = value; }
		}

	}
}
