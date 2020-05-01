using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPatternQueque
{
	public class Originator
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public uint Id { get; set; }

		public override string ToString()
		{
			return $"{this.Name} - {this.Address} - {this.Id}";
		}
	}
}
