using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_._assembly.spec.eq_
{
	public class ByNomina :
		nilnul.obj.eq_.Homomorph<AssemblyName, string>
		,
		_assembly.spec.EqI
	{
		public ByNomina() : base(
			a=> a.Name
		)
		{
		}


		static public ByNomina Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ByNomina>.Instance;
			}
		}


	}
}
