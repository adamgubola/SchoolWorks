﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    sealed class Owner
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public Owner(string name)
        {
            this.name= name;
        }

    }
}
