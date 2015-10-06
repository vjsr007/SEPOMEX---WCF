using System;
using Intranet.ws.DataContracts;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerCountingEntitiesReq
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "empty")]
        public Int32? empty { get; set; }
    }
}