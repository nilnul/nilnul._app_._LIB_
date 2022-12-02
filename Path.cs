using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app
{
	/// <summary>
	/// app.Path, so we can get the calling app (not the called dll)'s path from within the called dll
	/// </summary>
	static public class _PathX
	{
		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttr(Assembly assembly)
		{
			return assembly.CodeBase;
		}
		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttrOfThisAssembly()
		{
			return Assembly.GetExecutingAssembly().CodeBase;
		}

		/// <summary>
		/// including the filename
		/// </summary>
		/// <returns></returns>
		static public string CodebaseAttrOfCallingAssembly()
		{
			return Assembly.GetCallingAssembly().CodeBase;
		}



		static public string AppBase()
		{
			return AppDomain.CurrentDomain.SetupInformation.ApplicationBase; ;
		}

		static public string Where2findRefs()
		{
			return AppDomain.CurrentDomain.BaseDirectory; ;
		}

		static public string RelPath4PrivateRefs()
		{
			return AppDomain.CurrentDomain.RelativeSearchPath;
		}

		/// <summary>
		/// empty or cached
		/// </summary>
		/// <returns></returns>
		static public string LocationOfThisAssembly()
		{
			return Assembly.GetExecutingAssembly().Location;
		}


	}
}
