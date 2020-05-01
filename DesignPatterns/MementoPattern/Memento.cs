using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
	public class Memento
	{
		public readonly object _savedobject;
		public Memento(object savedobject)
		{
			this._savedobject = savedobject;
		}
	}
}
