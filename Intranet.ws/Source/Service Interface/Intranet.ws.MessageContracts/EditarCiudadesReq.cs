using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class EditarCiudadesReq
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "FiltroCiudad")]
        public Intranet.ws.DataContracts.Ciudad FiltroCiudad { get; set; }
    }
}