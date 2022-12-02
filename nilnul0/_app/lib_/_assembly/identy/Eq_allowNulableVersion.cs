using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_._assembly.identy
{

	public class Eq_allowNulableVersion : IEqualityComparer<(string,Version)>
	{
		static public EqualityComparer<Version> _VersionEq = EqualityComparer<Version>.Default;
		public bool Equals((string, Version) x, (string, Version) y)
		{
	
			return x.Item1 == y.Item1
				&&
				_VersionEq.Equals(x.Item2,y.Item2)
				//x.Item2 == y.Item2

				;
			//throw new NotImplementedException();
		}
		public int GetHashCode((string, Version) obj)
		{
	

			return obj.Item1.GetHashCode()
				&
				_VersionEq.GetHashCode(obj.Item2)
			
				;

		}



		static public Eq_allowNulableVersion Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq_allowNulableVersion>.Instance;
			}
		}

	}
}
