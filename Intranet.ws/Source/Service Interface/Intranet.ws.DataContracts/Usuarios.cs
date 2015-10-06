using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
	[WcfSerialization::CollectionDataContract(Namespace = "http://Intranet.ws.Model/2015/Seguridad")]
	public partial class Usuarios : System.Collections.Generic.List<Usuario>
	{
	}
}

