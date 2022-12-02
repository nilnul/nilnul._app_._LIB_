using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_._assembly.spec.eq_
{
	public class ByIdenty :
		nilnul.obj.eq_.homo_.EqDefault<AssemblyName, (string, System.Version), _assembly.identy.Eq>
		,
		_assembly.spec.EqI
	{
		public ByIdenty() : base(
			a=> lib_._assembly.spec._IdentyX.Identy(a)
		)
		{
		}


		static public ByIdenty Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ByIdenty>.Instance;
			}
		}


	}
}
