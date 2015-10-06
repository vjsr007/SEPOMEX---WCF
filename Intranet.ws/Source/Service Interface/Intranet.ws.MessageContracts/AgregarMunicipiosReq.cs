using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class AgregarMunicipiosReq
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "FiltroMunicipio")]
        public Intranet.ws.DataContracts.Municipio FiltroMunicipio { get; set; }
    }
}