using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
	[WcfSerialization::CollectionDataContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos")]
    public partial class UsuarioFunciones : System.Collections.Generic.List<UsuarioFuncion>
	{
	}
}

