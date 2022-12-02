using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_._assembly.spec
{
	/// <summary>
	/// </summary>
	static public class _IdentyX
	{
		static public (string,Version) Identy(
			AssemblyName n
		) {
			//var n=dll.GetName();
			return (n.Name,n.Version);

		}

		

	}
}
