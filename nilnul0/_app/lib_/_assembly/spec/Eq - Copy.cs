using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._app.lib_.assembly._name
{
	[Obsolete(nameof(_assembly.spec.Eq))]
	public class Eq : IEqualityComparer<AssemblyName>
	{

		public bool Equals(AssemblyName x, AssemblyName y)
		{
			//var pubKeyTokenEq = false;
			//var xPubKeyToken = x.GetPublicKeyToken();
			//var yPubKeyToken = y.GetPublicKeyToken();
			//if (xPubKeyToken is null)
			//{
			//	if (yPubKeyToken is null)
			//	{
			//		pubKeyTokenEq = true;
			//	}

			//}
			//else
			//{

			//}

			

			return x.Name == y.Name
				&&
				x.Version == y.Version
				&&
				x.CultureName == y.CultureName
				&&
				nilnul.objs.Eq1<byte>.Singleton.Equals(

					x.GetPublicKeyToken()?? new byte[0]
					,
					y.GetPublicKeyToken()??new byte[0]
				)

				;
			//throw new NotImplementedException();
		}

		public int GetHashCode(AssemblyName x)
		{
			var pubKeyTokenCode = x.GetPublicKeyToken();


			return x.Name.GetHashCode()
				&
				EqualityComparer<Version>.Default.GetHashCode(x.Version)
				//(x.Version is null?0 :x.Version.GetHashCode())
				&
				EqualityComparer<string>.Default.GetHashCode(x.CultureName)
				//( x.CultureName is null?0:x.CultureName.GetHashCode())
				&
				(
					//pubKeyTokenCode is null
					//?
					//0
					//:
					nilnul.objs.Eq1<byte>.Singleton.GetHashCode(

						pubKeyTokenCode??new byte[0]
					
					)
				)
				;

			//throw new NotImplementedException();
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
