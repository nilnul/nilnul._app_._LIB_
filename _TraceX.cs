using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace nilnul.app
{
	static public class _TraceX
	{


		static public void writeLine(string txt, char separator='-', int repeat=20) {

			writeLine(txt,  nilnul.txt.RepeatX.Repeat(separator,repeat));
		}

		static public void writeLine(string txt, string separator) {

			Trace.WriteLine(separator);

			Trace.WriteLine(txt);
			Trace.WriteLine(separator);

		}

		/// <summary>
		/// json
		/// </summary>
		/// <param name="memberName"></param>
		/// <param name="sourceFilePath"></param>
		/// <param name="sourceLineNumber"></param>
		/// <returns></returns>
		static public string Txt(
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0


			)
		{
			return $"{JsonConvert.SerializeObject( new { memberName,sourceFilePath,sourceLineNumber})}";
		}/* (MethodBase.GetCurrentMethod().DeclaringType.Name);
  //Or, to get full name (including namespace)
  (MethodBase.GetCurrentMethod().DeclaringType.FullName);*/

		static public void TraceAsErr(
			string err,
			[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
			[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
			[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0
		)
		{
			Trace.TraceError( $"{JsonConvert.SerializeObject( new { memberName,sourceFilePath,sourceLineNumber,err})}"
			);
		}/* (MethodBase.GetCurrentMethod().DeclaringType.Name);
  //Or, to get full name (including namespace)
  (MethodBase.GetCurrentMethod().DeclaringType.FullName);*/

	}
}
