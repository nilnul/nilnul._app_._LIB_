using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.app._run._cfg.entry_.txtDict_
{

	public class SerializableStringDictionary :
		System.Collections.Specialized.StringDictionary
		, System.Xml.Serialization.IXmlSerializable
	{
		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(System.Xml.XmlReader reader)
		{
			while (reader.Read() &&
				!(reader.NodeType == System.Xml.XmlNodeType.EndElement && reader.LocalName == this.GetType().Name))
			{
				var name = reader["Name"];
				if (name == null)
					throw new FormatException();

				var value = reader["Value"];
				this[name] = value;
			}
		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			foreach (System.Collections.DictionaryEntry entry in this)
			{
				writer.WriteStartElement("Pair");
				writer.WriteAttributeString("Name", (string)entry.Key);
				writer.WriteAttributeString("Value", (string)entry.Value);
				writer.WriteEndElement();
			}
		}
	}
	/*
	 Resulting XML fragment will look similar to:

...
<setting name="PluginSettings" serializeAs="Xml">
    <value>
        <SerializableStringDictionary>
            <Pair Name="property1" Value="True" />
            <Pair Name="property2" Value="05/01/2011 0:00:00" />
        </SerializableStringDictionary>
    </value>
</setting>

	 */
}