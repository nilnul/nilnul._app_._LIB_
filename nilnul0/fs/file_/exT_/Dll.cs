using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file_.exT_
{
	public class Dll : nilnul.fs.file_.Ext
	{
		public Dll(FileI val) : base(val, ".dll")
		{

		}

		public Dll(string s):this(new File(s))
		{

		}
	}
}
