using System;
using Intranet.ws.DataContracts;
using WCF = global::System.ServiceModel;

namespace Intranet.ws.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class ObtenerCountingEntitiesRes
    {
        [WCF::MessageBodyMember(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "CountingEntities")]
        public CountingEntities CountingEntities { get; set; }
    }
}