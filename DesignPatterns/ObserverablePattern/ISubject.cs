using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverablePattern
{
	public interface ISubject
	{
		void Add(IObserve observer);
		void Remove(IObserve observer);
		void Change(object obj);
		void NotifyAll();
		object GetState();
	}
}
