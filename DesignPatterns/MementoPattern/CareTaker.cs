using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
	public class CareTaker
	{
		private List<Memento> _mementolist = new List<Memento>();
		private Originator _originator;

		public CareTaker(Originator originator)
		{
			this._originator = originator;
		}

		public void SaveToMemento()
		{
			Originator originator = new Originator(this._originator.GetState());
			this._mementolist.Add(new Memento(originator));
		}

		public void RemoveState(int index)
		{
			this._mementolist.RemoveAt(index);
		}

		public Originator GetState(int index)
		{
			if (index >= this._mementolist.Count) return null;
			Originator originator = (Originator)this._mementolist[index]._savedobject;
			return originator;
		}

		public Originator GetState(Memento memento)
		{
			foreach(var mementoItem in this._mementolist)
			{
				if (memento.Equals(memento))
					return (Originator) mementoItem._savedobject;
			}
			return null;
		}
	}
}
