using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._trace.filter_
{
	
		public class WarnOnly : TraceFilter
		{
			override public bool ShouldTrace(TraceEventCache cache, string source,
				TraceEventType eventType, int id, string formatOrMessage,
				object[] args, object data, object[] dataArray)
			{
				return eventType == TraceEventType.Warning;
			}
		}
	
}
