using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_._assembly.identy
{

	public class Eq : IEqualityComparer<(string,Version)>
	{
		public bool Equals((string, Version) x, (string, Version) y)
		{
			return x.Item1 == y.Item1
				&&
				x.Item2 == y.Item2
			;
		}
		public int GetHashCode((string, Version) obj)
		{
			return obj.Item1.GetHashCode()
				&
				obj.Item2.GetHashCode()
			;
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
