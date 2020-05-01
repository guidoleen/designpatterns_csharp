using System;

namespace DesignPatterns.MementoPatternQueque
{
	public class CareTaker<T> : IDisposable
	{
		// | 4 | 3 | 2 | 1 |

		private Memento<T> _head;
		private Memento<T> _tail;
		private int _counter = 0;
		public void Enqueue(T originator)
		{
			this._counter++;

			var memento = new Memento<T>() { Next = null, Prev = null };
			memento.SetState(originator);

			if (this._tail != null)
			{
				this._head.Next = memento;
				memento.Prev = this._head;

				this._head = memento;
			}
			else
			{
				this._head = memento;
				this._tail = memento;
			}

			if (this._counter > MementoConstants.NumberOfItemsInQueue)
				this.Dequeue();

		}
		public void Dequeue()
		{
			if (this._tail == null) return;

			var currentTail = this._tail;
			if (this._tail.Next != null)
				this._tail = this._tail.Next;

			this.Dispose(currentTail);
		}
		public Memento<T> Peek()
		{
			if(this._tail != null)
			 return this._tail;

			return null;
		}

		public Memento<T> Pop()
		{
			if (this._head != null)
				return this._head;

			return null;
		}
		public bool Contains(T originator)
		{
			return GetOriginator(originator) != null ? true : false;
		}
		public void Clear()
		{
			if (this._head == null) return;

			var memento = this._head;
			while(memento != null)
			{
				var current = memento;
				memento = memento.Prev;

				this.Dispose(current);
			}
		}

		private Memento<T> GetOriginator(T originator)
		{
			if (this._tail == null) return null;

			Memento<T> current = this._tail;
			while (current != null)
			{
				if (current.GetState().Equals(originator))
					return current;

				current = current.Next;
			}
			return null;
		}

		public virtual void Dispose(object obj)
		{
			GC.SuppressFinalize(obj);
			obj = null;
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
