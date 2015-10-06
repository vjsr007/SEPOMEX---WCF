using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class EditarCodigosPostalesReq
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "FiltroCodigoPostal")]
        public Intranet.ws.DataContracts.CodigoPostal FiltroCodigoPostal { get; set; }
    }
}