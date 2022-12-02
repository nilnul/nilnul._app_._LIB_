using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace.listener_.file_._templatedName
{
	public class Filename : System.Diagnostics.TextWriterTraceListener
	{
		private string _filename;

		public string filename
		{
			get { return _filename; }
			set { _filename = value; }
		}

		public Filename(string filename) :
			base(
				filename
			)
		{
			//base.Writer = new StreamWriter(filename.Replace("@time",
			//		nilnul.time.phrase_.Full.Singleton.phrase(
			//		)
			//	), false);
			_filename = filename;
			
		}
		



	}
}
