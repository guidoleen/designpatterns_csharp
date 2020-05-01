using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverablePattern
{
	public class SubjectTextReader : ISubject
	{
		private List<IObserve> _observerlist = new List<IObserve>();
		private object _state;

		public void Add(IObserve observer)
		{
			_observerlist.Add(observer);
		}

		public void Change(object obj)
		{
			this._state = obj;
			this.NotifyAll();
		}

		public object GetState()
		{
			return this._state;
		}

		public void NotifyAll()
		{
			foreach (var observer in this._observerlist)
			{
				observer.Update();
			}
		}

		public void Remove(IObserve observer)
		{
			this._observerlist.Remove(observer);
		}
	}
}
