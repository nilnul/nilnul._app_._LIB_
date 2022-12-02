using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.trace.listener_.file_.templatedName_
{
	public class BlockQuoted : TemplatedName
	{
		static public ConcurrentQueue<BlockQuoted> Instances = new ConcurrentQueue<BlockQuoted>();
		public string separator = nilnul.txt.RepeatX.Repeat("-", 20);
		public BlockQuoted(string filename) : base(filename)
		{
			Instances.Enqueue(this);
		}

		public override void WriteLine(string message)
		{
			base.WriteLine("");
			base.WriteLine(separator);
			base.WriteLine(message);
			base.WriteLine(separator);
			base.WriteLine("");
		}


		public override void WriteLine(object o, string category)
		{
			base.WriteLine("");
			base.WriteLine(separator);
			base.WriteLine(o, category);
			base.WriteLine(separator);
			base.WriteLine("");
		}
		public override void WriteLine(string message, string category)
		{
			base.WriteLine("");
			base.WriteLine(separator);
			base.WriteLine(message, category);
			base.WriteLine(separator);
			base.WriteLine("");
		}
		public override void WriteLine(object o)
		{
			base.WriteLine("");
			base.WriteLine(separator);
			base.WriteLine(o);
			base.WriteLine(separator);
			base.WriteLine("");
		}
	}
}
