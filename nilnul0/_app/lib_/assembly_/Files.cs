using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using NuGet.Common;
//using NuGet.Configuration;
//using NuGet.Frameworks;
//using NuGet.Packaging.Core;
//using NuGet.Versioning;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using nilnul.fs.address_;
using nilnul.fs._address._route.division_.div;
using nilnul.fs.address_.spear;

namespace nilnul._app.lib_.assembly_
{
	/// <summary>
	/// for refs of each assembly. for the name, we don't need to load assembly; rather we use AssemblyName.GetAssemblyName
	/// </summary>
	public class Files4reflect
	{

		/*
		 * The reflection-only context is no different from other contexts. Assemblies that are loaded into the context can be unloaded only by unloading the application domain.*/

		/// <summary>
		/// maintain a dynamic collection assemblies in the installed folder
		/// </summary>
		/// <remarks>
		/// </remarks>
		public class Assemblies
		{
			private List<Assembly> _loaded = new List<Assembly>(
				
			);

			public List<Assembly> loaded
			{
				get
				{
					return _loaded;
				}
			}


			public IEnumerable< Assembly> nulablesFound(
				string identity,
				Version version
			)
			{
				return _loaded.Where(
					a => {
						var spec = a.GetName();
						return spec.Name == identity && spec.Version >= version;
					}

				);

			
			}

			public Assembly nulableFound(
				string identity,
				Version version
			)
			{
				return nulablesFound(identity,version).FirstOrDefault();
			}

			public Assembly nulableFound(
				(string key, Version version) versioned
				)
			{
				return nulableFound(versioned.key, versioned.version);
			}


			/// <summary>
			/// given and identity, and a min ver, find  one the dependencies of which are exact the same as given
			/// </summary>
			/// <returns></returns>
			/// <param name="deps">constraint</param>
			public Assembly nulableFound(
				string identity,
				System.Version versionMin,
				IEnumerable<AssemblyName> deps
				,
				string framework = "net48"
				)
			{
				

				return nulablesFound(identity,versionMin).Where(
					a =>
					a.GetReferencedAssemblies().All(
						refed =>
							deps.Where(d => d.Name == refed.Name).All(
								d => d == refed
							)

					)
				).FirstOrDefault();

				

			}


			/// <summary>
			/// existed as document
			/// </summary>
			/// <param name="denote"></param>
			/// <returns></returns>
			public Assembly ensure_assumeFile(string address4found)
			{

				var alreadyLoad = _loaded.FirstOrDefault(

					a => nilnul.fs.address.prefixed.Eq.Singleton.Equals(a.Location, address4found)
				);

				if (alreadyLoad is null)
				{
					var assembly = Assembly.ReflectionOnlyLoadFrom(address4found.ToString());
					_loaded.Add(assembly);
					return assembly;

				}

				return alreadyLoad;


			}


			/// <summary>
			/// nulable
			/// </summary>
			/// <param name="denote"></param>
			/// <returns></returns>
			public Assembly ensureFroAddress(string address4found)
			{
				if (nilnul.fs.address_.spear.be_._FileX._Be(address4found))
				{

					return ensure_assumeFile(address4found);
				}
				return null;

			}

		}

	}
}