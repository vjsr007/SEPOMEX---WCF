using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerCodigosPostalesRes
	{
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "CodigosPostales")]
        public Intranet.ws.DataContracts.CodigosPostales CodigosPostales { get; set; }
	}
}