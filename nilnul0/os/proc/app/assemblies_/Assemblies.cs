using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	using nilnul.obj;
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

namespace nilnul.os.proc.app.assemblies_
{

		/*
		 * The reflection-only context is no different from other contexts. Assemblies that are loaded into the context can be unloaded only by unloading the application domain.*/

		/// <summary>
		/// maintain a dynamic collection assemblies in the installed folder
		/// </summary>
		/// <remarks>
		/// </remarks>
		public class Reflect
		{
			private ConcurrentDictionary<AssemblyName, Assembly> _loaded = new ConcurrentDictionary<AssemblyName, Assembly>(
				nilnul._app.lib_.assembly._name.Eq.Singleton
			);

			public ConcurrentDictionary<AssemblyName, Assembly> loaded
			{
				get
				{
					return _loaded;
				}
			}

			

			
			

		
			/// <summary>
			/// nulable
			/// </summary>
			/// <param name="denote"></param>
			/// <returns></returns>
			public Assembly ensure(nilnul.fs.address_.SpearI address4found)
			{
				
				if (nilnul.fs.address_.spear.be_.File.Singleton.be(address4found))
				{

					var alreadyLoad = _loaded.FirstOrDefault(

						a => nilnul.fs.address.prefixed.Eq.Singleton.Equals(a.Value.Location, address4found.ToString())
					);

					if (alreadyLoad.Key is null)
					{
						var assembly = Assembly.ReflectionOnlyLoadFrom(address4found.ToString());
						_loaded.TryAdd(assembly.GetName(), assembly);
						return assembly;

					}
					else
					{
						return alreadyLoad.Value;
					}
				}
				else
				{
					return null;
				}
			}

	



		}
	}