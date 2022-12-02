using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_.assembly.be_
{

	static public class _DebugX
	{
		static public bool IsAssemblyDebugBuild(Assembly assembly)
		{
			return assembly.GetCustomAttributes(false).OfType<DebuggableAttribute>().Any(da => da.IsJITTrackingEnabled);
		}
	}
}
