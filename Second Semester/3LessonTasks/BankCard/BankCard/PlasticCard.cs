using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class PlasticCard: IProperty
    {
		private string owner;

		public string Owner
		{
			get { return owner; }
			protected set { owner = value; }
		}


		public PlasticCard(string owner)
		{
			this.Owner = owner;

		}
	}
}
