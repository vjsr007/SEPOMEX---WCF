using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Intranet.ws.FaultContracts
{
	[WcfSerialization::DataContract(Namespace = "http://Intranet.ws.Model/2015/Error", Name = "Error")]
	public partial class Error 
	{
		[WcfSerialization::DataMember(Name = "Mensaje", IsRequired = false, Order = 0)]
        public string Mensaje { get; set; }		
	}
}
