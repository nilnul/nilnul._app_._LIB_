using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_.assembly.eq_
{
	public class ByIdenty :
		nilnul.obj.eq_.homo_.EqDefault<Assembly, (string, System.Version), _assembly.identy.Eq>
		,
		assembly.EqI
	{
		public ByIdenty() : base(
			a=> lib_.assembly._IdentyX.Identy(a)
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
