using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.assembly
{
	/*
	
	 
	 */
	class Load
	{

		static void Main()
		{
			//https://michaelscodingspot.com/how-to-resolve-net-reference-and-nuget-package-version-conflicts/
			AppDomain.CurrentDomain.AssemblyResolve += (sender, resolveArgs) =>
			{
				string assemblyInfo = resolveArgs.Name;// e.g "Lib1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
				var parts = assemblyInfo.Split(',');
				string name = parts[0];
				var version = Version.Parse(parts[1].Split('=')[1]);
				string fullName;
				if (name == "Lib1" && version.Major == 1 && version.Minor == 0)
				{
					fullName = new FileInfo(@"V10\Lib1.dll").FullName;
				}
				else if (name == "Lib1" && version.Major == 1 && version.Minor == 1)
				{
					fullName = new FileInfo(@"V11\Lib1.dll").FullName;
				}
				else
				{
					return null;
				}

				return Assembly.LoadFile(fullName);
			};
		}
}
