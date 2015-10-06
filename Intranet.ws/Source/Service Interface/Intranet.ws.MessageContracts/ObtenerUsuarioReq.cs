using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class ObtenerUsuarioRes
	{
		[WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "Usuarios")]
        public Intranet.ws.DataContracts.Usuarios Usuarios { get; set; }
	}
}