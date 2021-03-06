using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class ObtenerUsuarioReq
	{
		[WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "FiltroUsuario")]
        public Intranet.ws.DataContracts.Usuario FiltroUsuario { get; set; }
	}
}