using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/*
 whether [nilnul].[App] is dependent on [nilnul].[Acc] or the contrary?
If we deem [nilnul].[App] is dependent on [nilnul].[Acc], this is consistent with the scenario that the OS, whichi is precedent to the App, has [Acc] built in, thus Acc has been ready before App. App is run under the Acc; but if another person logins into the OS with a different Acc, the person can run a seperate instance of the same App. So the development of App shall keep multi-usr scenario in mind; in other words, the App is run under various accounts.
	given one account, the app has only one account at disposal. So if the app wants to support multiple usr itself (for example, switch usr under same acc), the app would have to setup a subsys for multiple usr itself. We differentiate the acc of Os from the usr of App with variod name "Acc", and "Usr"
	for a web app, the app runs on one acc of the os. But the app must support multiple users from around the world. For a web app, or any Client app such as AliPay, the app is installed on each OS Acc; but what app is really caring about is the usr registered with the app itself, not the acc of usr's device.

usr is for human, acc is for credential

 */
 
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("nilnul._app_._LIB_")]
[assembly: AssemblyDescription("an application on Os including: exe, referenced dll, configuration, which includes settings(program settings and user settings and hierachial directory, physical or virtual, settings), customized Fs storage at user folders (including temp folders) / program folders /  or other conventional or user specified place")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("nilnul")]
[assembly: AssemblyProduct("nilnul._app_._LIB_")]
[assembly: AssemblyCopyright("wangyoutian@nilnul.com")]
[assembly: AssemblyTrademark("nilnul._app_._LIB_")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("fee9aa40-d23d-4436-bf85-5811aa6fce24")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.1.0.1")]
//[assembly: AssemblyVersion("1.0.2.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
