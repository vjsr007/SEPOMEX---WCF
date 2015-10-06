using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class EditarPaisesReq
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "FiltroPais")]
        public Intranet.ws.DataContracts.Pais FiltroPais { get; set; }
    }
}