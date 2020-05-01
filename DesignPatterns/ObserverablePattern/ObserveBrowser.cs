using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverablePattern
{
	public class ObserveBrowser : IObserve
	{
		private ISubject _textreader;
		public ObserveBrowser(ISubject textreader)
		{
			this._textreader = textreader;
			this._textreader.Add(this);
		}
		public void Update()
		{
			this.DoWork();
		}

		private void DoWork()
		{
			var txtreaderState = this._textreader.GetState();
			
			Console.WriteLine($"Greatings from: {this.GetType().ToString()} With a state: {txtreaderState}");
		}
	}
}
