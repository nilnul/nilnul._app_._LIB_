using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_.assembly.eq_
{
	public class ByNomina :
		nilnul.obj.eq_.Homomorph<Assembly, string >
		,
		assembly.EqI
	{
		public ByNomina() : base(
			a=> a.GetName().Name
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
