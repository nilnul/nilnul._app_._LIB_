using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace.listener_.file_
{
	public class TemplatedName : _templatedName.Filename
	{
		public TemplatedName(string filename) :
			base(
				filename.Replace("@time", 
					nilnul.time_.datetime.phrase_.Full.Singleton.phrase(
					)
				)
			)
		{
			//base.Writer = new StreamWriter(filename.Replace("@time",
			//		nilnul.time.phrase_.Full.Singleton.phrase(
			//		)
			//	), false);

			
		}

		//public TemplatedName():this(Process.GetCurrentProcess().StartTime)
		//{

		//}


	}
}
