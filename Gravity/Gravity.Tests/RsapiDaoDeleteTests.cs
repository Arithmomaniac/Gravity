﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity.Tests
{
    public class RsapiDaoDeleteTests
    {
		public void DeleteRelativityObjectRecusively()
		{
			//DeleteRelativityObjectRecusively<T>(T theObjectToDelete)

			//write a class with nested child objects
			// DeleteRDO should be called on the root only
			// Each other level should have DeleteRDOs called on the whole child collection (recursively)
			// TO INVESTIGATE: Do you even need to do a recursive delete, or can you just delete the root?
		}
	}
}
