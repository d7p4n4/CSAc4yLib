
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4.Final.Class;
using GuidLibrary;

namespace d7p4n4.PreProcessed.Class
{
	            [GUID("")]
	public class Ac4yPreProcessed : Ac4yIdentification

	{
    		public String serialization { get; set; }
    		public Ac4yIdentificationBase template { get; set; }
    		public String GUID { get; set; }
    		public String HumanId { get; set; }
    		public String PublicHumanId { get; set; }
    		public Int32 id { get; set; }
		
		public Ac4yPreProcessed()
		{
			GUID = "";
		}
	}
}