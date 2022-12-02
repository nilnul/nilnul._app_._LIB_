using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace_
{
	static public class _OsEvtX
	{
		public static void WriteEntry(string MySource)
		{

			// Create an EventLog instance and assign its source.
			EventLog myLog = new EventLog();
			myLog.Source = MySource;

			// Write an informational entry to the event log.    
			myLog.WriteEntry("Writing to event log.");

		}
	}
}
