using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app.nilnul0._app.lib_.assembly_.sys_
{

	/*
	There is something strange that happens with System packages that are added as nuget references. There should be no need to add System libraries as packages, they should exist on the host, but in a few cases, it is necessary, I think a similar issue exists with System.Runtime.Caching related to version conflicts.

I think the problem is that since the library is in the GAC, the build system ignores copying it to the output assuming that it is present and available without needing to be packaged.

Visual Studio, as you might imagine, behaves by its own rules which is really annoying because it is hard to see why the problem is happening.

To be extra annoying, I can't quite remember what I had to do to fix it. I might have uninstalled the library from the GAC, set the reference properties Copy Local to be true (if not already) or possibly referenced the dll directly from the SDK location on disk (with copy local = true) and not use the nuget package at all. 

stackoverflow.com/questions/47782412/referenced-system-net-http-assembly-is-not-copied-to-the-output-bin-release-cata
answered Oct 6, 2020 at 15:44
Luke Briner	
	 
	 */
	class Version
	{
	}

	/*
	 * stackoverflow.com/questions/57985155/what-does-the-generatebindingredirectsoutputtype-option-do
	 * 
	  <Target Name="GenerateBindingRedirectsUpdateAppConfig"
    AfterTargets="GenerateBindingRedirects"
    Condition="'$(AutoGenerateBindingRedirects)' == 'true' and '$(GenerateBindingRedirectsOutputType)' == 'true' and Exists('$(_GenerateBindingRedirectsIntermediateAppConfig)')">

 
	 As we can see here we need both AutoGenerateBindingRedirects and GenerateBindingRedirectsOutputType flags to make some things for "autogenerating binding redirects" work.

GenerateBindingRedirectsOutputType will be set to true in case you are building exe or winexe as written here.

	<GenerateBindingRedirectsOutputType Condition="'$(OutputType)'=='exe' or '$(OutputType)'=='winexe'">true</GenerateBindingRedirectsOutputType>

So if you need binding redirects to generate while building library dlls you need to specify the GenerateBindingRedirectsOutputType flag manually.
answered Sep 18, 2019 at 4:51
saltukkos




It is not needed for projects that generate .exe executables but needed for unit test projects.

answered Sep 18, 2019 at 4:52
Mahesh Waghmare
	 */
}
