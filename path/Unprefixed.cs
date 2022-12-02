using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.path
{
	/// <summary>
	/// remove:
	///		file:///
	///		/?:/
	///		
	/// </summary>
	static public class _UnprefixedX
	{
		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttr(Assembly assembly)
		{
			return nilnul.fs.address._UrlX.Unprefix(assembly.CodeBase );
		}

		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttrOfThisAssembly()
		{
			return nilnul.fs.address._UrlX.Unprefix(_PathX.CodebaseAttrOfThisAssembly() );
		}
		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttrOfCallingAssembly()
		{
			return nilnul.fs.address._UrlX.Unprefix(Assembly.GetCallingAssembly().CodeBase);
		}



		static public string AppBase()
		{
			return nilnul.fs.address._UrlX.Unprefix(AppDomain.CurrentDomain.SetupInformation.ApplicationBase) ;
		}

		static public string Where2findRefs()
		{
			return nilnul.fs.address._UrlX.Unprefix(AppDomain.CurrentDomain.BaseDirectory) ;
		}

		static public string RelPath4PrivateRefs()
		{
			return nilnul.fs.address._UrlX.Unprefix(AppDomain.CurrentDomain.RelativeSearchPath);
		}

		/// <summary>
		/// empty or cached
		/// </summary>
		/// <returns></returns>
		static public string LocationOfThisAssembly()
		{
			return nilnul.fs.address._UrlX.Unprefix(Assembly.GetExecutingAssembly().Location);
		}


	}
}
