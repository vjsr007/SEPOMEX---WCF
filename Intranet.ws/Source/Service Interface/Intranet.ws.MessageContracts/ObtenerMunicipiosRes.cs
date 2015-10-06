using System;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
	[WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerMunicipiosRes
	{
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "Municipios")]
        public Intranet.ws.DataContracts.Municipios Municipios { get; set; }
	}
}