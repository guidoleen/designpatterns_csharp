using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPatternQueque
{
	public class Memento<T>
	{
		public Memento<T> Prev { get; set; }
		public Memento<T> Next { get; set; }

		private T _originatorstate;
		public void SetState(T originatorState)
		{
			this._originatorstate = originatorState;
		}

		public T GetState()
		{
			return _originatorstate;
		}
	}
}
