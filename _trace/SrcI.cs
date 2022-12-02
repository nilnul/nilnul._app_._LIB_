using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._trace
{
	/*Indentation is still controlled globally through the Trace class.  Use Trace.Indent or Trace.IndentLevel to set the indentation for all tracing statements irrelevant of the source.  TraceSource is not an upgrade to Trace as much as it is an more finely detailed version.  You will use TraceSource to enable, configure and disable different parts of your app.  This permits you to turn tracing on and off for those portions of your app that you need to trace.  The standard Trace is global but can put out far too much information to be useful.  TraceSource, and filters if they are used, act as a filtering mechanism to control what gets sent to the trace subsystem.  Under the hood TraceSource ultimately still uses the original trace subsystem and hence is impacted by the indentation settings.

Hope this helps,

Michael Taylor - 7/19/06*/
	/// <summary>
	/// 
	/// </summary>
	public interface SrcI
	{
	}
}
/* Each time you decleare a new TraceSource (TraceSource ts = new TraceSource("somename"); instance, you get a new TraceSource object, but it references the same config information. 
 
	  So, if you create a new TraceSource in each of several classes and you use the same name for each one, you will get different instances of TraceSource, but they will all be configured the same. In short, there is no need to try to share the TraceSource instances among classes. There is also no need to create a dummy class with a static singleton.*/
