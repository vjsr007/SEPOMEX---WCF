using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerUsuarioFuncionesRes
	{
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "UsuarioFunciones")]
        public Intranet.ws.DataContracts.UsuarioFunciones UsuarioFunciones { get; set; }
	}
}