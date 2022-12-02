using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace.listener_.file_
{
	public class Console : System.Diagnostics.TextWriterTraceListener
	{
		public Console() :
			base(
				System.Console.Out
			)
		{
			//base.Writer = new StreamWriter(filename.Replace("@time",
			//		nilnul.time.phrase_.Full.Singleton.phrase(
			//		)
			//	), false);
		}
		



	}
}
