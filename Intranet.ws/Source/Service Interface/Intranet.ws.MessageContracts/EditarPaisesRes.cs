using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)]
    public partial class EditarPaisesRes
	{
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "Respuesta")]
        public int? Respuesta { get; set; }
	}
}