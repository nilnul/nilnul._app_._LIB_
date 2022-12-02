using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._trace
{
	/// <summary>
	/// Instrumentation — you add trace code to your application.
	///by instrumenting the application — that is, by placing trace statements at strategic locations in your code.
	///</summary>
	interface IInstrumentation
	{
	}
}

/*During development, all debug and trace output methods write information to the Output window in Visual Studio by default.
In a deployed application, the methods write tracing information to the targets you specify. For more information on specifying an output target for tracing or debugging, see Trace Listeners. */