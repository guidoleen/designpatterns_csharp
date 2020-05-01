using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverablePattern
{
	public class ObserveMobileApp : IObserve
	{
		private ISubject _textreader;
		public ObserveMobileApp(ISubject textreader)
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
			switch(txtreaderState)
			{
				case 20:
					{
						Console.WriteLine($"This is great");
						break;
					}
					
				case 30:
					{
						Console.WriteLine($"This is to large");
						break;
					}
			}
			Console.WriteLine($"Greatings from: {this.GetType().ToString()}" );
		}
	}
}
