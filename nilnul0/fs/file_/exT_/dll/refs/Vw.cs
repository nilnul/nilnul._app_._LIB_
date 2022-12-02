using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.exT_.dll.refs
{
	/// by ildasm (options for cli)

	/// <summary>
	/// </summary>
	static public class _VwX
	{
		static public AssemblyName[] Refs_assumeDll(string dll) {

			var a= Assembly.ReflectionOnlyLoadFrom(dll);
			return a.GetReferencedAssemblies();
		}

		static public IEnumerable<AssemblyName> Refs(nilnul.fs.file_.exT_.Dll dll) {
			return Refs_assumeDll(dll.ToString());
		}


	}
}
