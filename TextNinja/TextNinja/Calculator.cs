using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNinja
{
    public class Calculator
    {
		public int Add(int x, int y)
		{
			return x + y;
		}
		static void Main(String[] args)
		{
			var calculator = new Calculator();

			int result = calculator.Add(5, 6);

			if (result != 11)
				throw new InvalidOperationException();
		}
	}
}
