using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern
{
	public class Originator
	{
		private OriginatorPerson _personinfo; // State of object

		public Originator(OriginatorPerson personinfo)
		{
			this._personinfo = personinfo;
		}

		public OriginatorPerson GetState()
		{
			return this._personinfo;
		}

		public void SetState(Originator state)
		{
			this._personinfo = state._personinfo;
		}

		public void SetState(OriginatorPerson personinfo)
		{
			this._personinfo = personinfo;
		}

		public override string ToString()
		{
			return $"PersonName: {this._personinfo.Name} - PersonAddress: {this._personinfo.Address}";
		}
	}
}