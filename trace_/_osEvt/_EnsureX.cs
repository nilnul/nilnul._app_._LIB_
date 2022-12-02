using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace_._osEvt
{
	static public class _EnsureX
	{
		public static void Main(string MySource,string logName)
		{

			// Create the source, if it does not already exist.
			if (!EventLog.SourceExists(MySource))
			{
				//An event log source should not be created and immediately used.
				//There is a latency time to enable the source, it should be created
				//prior to executing the application that uses the source.
				//Execute this sample a second time to use the new source.
				EventLog.CreateEventSource(MySource, logName);
				//Console.WriteLine("CreatedEventSource");
				//Console.WriteLine("Exiting, execute the application a second time to use the source.");
				// The source is created.  Exit the application to allow it to be registered.
			}

			

		}
	}
}
