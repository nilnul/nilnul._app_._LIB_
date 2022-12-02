using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app
{
	/// <summary>
	/// Logging supports severity levels (such as INFO, DEBUG, WARN, ERROR, &c), that allow you to filter the output accordingly.
	/// </summary>
	/// <remarks>
	///记录 - 记录关键参数，例如随机数生成器的种子。这类记录可以用来重现代码，发现漏洞并追踪意料之外的结果。
	/// </remarks>
	public interface ILog
	{
	}
}
