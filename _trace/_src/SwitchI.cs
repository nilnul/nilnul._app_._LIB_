using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._trace._src
{
	/// <summary>
	/// The Switch on a TraceSource determines whether any output gets generated.By default, if it is not configured, there will be no output.
	/// It can be set via code:
	///		static TraceSource source = new TraceSource("WebAppLog");
	///		source.Switch.Level = SourceLevels.Verbose; 
	/// </summary>
	interface SwitchI
	{
		/* [SwitchAttribute("SourceSwitch", typeof(SourceSwitch))]
        static void Main()
        {*/
	}
}
