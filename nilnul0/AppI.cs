using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// an appDomain, in a process. a process can have multiple app domain (one app can load another). if an app doesnot load any other app, this app is the only app in the process
	/// 
	/// on Os is each App. this project is the delegation of the applications part of an OS such as WindowsOs
	///
	/// run on a computer 
	/// run on an os
	/// a resource, the access to which is controlled per Acc
	/// data+prog. the prog controls the access to data.
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		resource manager
	/// resources+management=app.
	///
	/// On second thought, I think acc shall go before app as app=rsc+acc
	/// app is precursor to acc. acc is based on app, in that:
	///		app is resources, which is without access/account
	///		acc is a subtype of app.
	///		in acc, we need to manage roles/permissions; and there need us to already establish app.
	///		acc.app is called, say, web.app, and is not called app.
	///	
	/// </remarks>
	public interface IApp
	{
	}
}

