using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app_.dotnet_.dev
{
	static public class _PathX
	{
		static public fs.AddressI PrjBaseAsAddress(Assembly  assembly) {
			return nilnul.fs.address.op_.unary_._UpX._assumeUpNatural(
				nilnul.app.path._UnprefixedX.CodebaseAttr(assembly), 3
			);
		}

		static public fs.AddressI PrjBaseAsAddress_ofCalling() {
			return PrjBaseAsAddress(Assembly.GetCallingAssembly());
		}

		static public fs.AddressI PrjBaseAsAddress_ofEntry() {
			return PrjBaseAsAddress(Assembly.GetEntryAssembly());
		}

	}
}
