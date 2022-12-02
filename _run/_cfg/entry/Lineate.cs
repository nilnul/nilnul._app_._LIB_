using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._run._cfg.entry
{
	/*
	 The problem is that the Dictionary doesn't serialize to XML.
	Dictionary is not saved because there is no implement XmlSerializable.
	You have two options. You can specify your own serialization methods for the dictionary, or you can cheat.

If you don't care about being able to read/edit the values in the XML, you can add a [SettingSerializeAs(SettingsSerializeAs.Binary)] attribute to the setting. Gets the job done, but it's the quick-and-dirty approach.
	 */
	/// <summary>
	/// 
	/// </summary>
	class Lineate
	{
	}
}
