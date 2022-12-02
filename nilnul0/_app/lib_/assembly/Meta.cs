using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_.assembly
{
	/*An assembly always contains an assembly manifest. Assembly manifest is the metadata of an assembly. It contains assembly definition identity, files in the assembly, type reference information, referenced assemblies, among other things.

 */
	/// <summary>
	/// meta used in reference resolving, including: name, version, culture, publickKeyToken.
	/// </summary>
	static public class _MetaX
	{
		static public AssemblyName _NameEtc_assumeDll(
			string dll
		) {
			return  AssemblyName.GetAssemblyName(dll);

		}
		static public AssemblyName NameEtc(
			nilnul.fs.file_.exT_.Dll dll
		) {
			return  _NameEtc_assumeDll(dll.ToString());

		}

		static public AssemblyName NameEtc(
			string dll
		) {
			return  NameEtc(new fs.file_.exT_.Dll(dll) );

		}

	}
}
