using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverablePattern
{
	public class ObserverLauncher
	{
		public void StartObserver()
		{
			ISubject subject = new SubjectTextReader();
			IObserve observeMobile = new ObserveMobileApp(subject);
			IObserve observeBrowser = new ObserveBrowser(subject);

			string key = "";
			while (true) // (key == 0 || key != 10)
			{
				key = Console.ReadLine();
				subject.Change(key);
			}
		}
	}
}
