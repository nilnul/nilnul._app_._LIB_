using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app_.notepad
{
	static public class _StartX
	{
		public static void Exe(SecureString securePwd)
		{
			Process.Start("Notepad.exe", "MyUser", securePwd, "MYDOMAIN");
		}
	}
}
