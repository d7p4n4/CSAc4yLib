
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4.Final.Class;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("")]
	public class Ac4yIdentificationPreProcessed : Ac4yIdentificationBase

	{
    		public Ac4yIdentificationBase template { get; set; }
    		public Int32 id { get; set; }
		
		public Ac4yIdentificationPreProcessed()
		{
			GUID = "";
		}
	}
}