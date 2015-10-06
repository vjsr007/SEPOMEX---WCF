using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerPaisesRes
	{
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "Paises")]
        public Intranet.ws.DataContracts.Paises Paises { get; set; }
	}
}