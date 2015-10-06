using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
	[WcfSerialization::DataContract(Namespace = "http://Intranet.ws.Model/2015/Seguridad", Name = "Usuario")]
	public partial class Usuario 
	{
		[WcfSerialization::DataMember(Name = "UsuarioID", IsRequired = false, Order = 0)]
        public int? UsuarioID { get; set; }			
		
		[WcfSerialization::DataMember(Name = "Nombre", IsRequired = false, Order = 1)]
        public string Nombre { get; set; }

		[WcfSerialization::DataMember(Name = "Pass", IsRequired = false, Order = 2)]
        public string Pass { get; set; }
		
		[WcfSerialization::DataMember(Name = "Activo", IsRequired = false, Order = 3)]
        public string Activo { get; set; }
		
		[WcfSerialization::DataMember(Name = "Rol", IsRequired = false, Order = 4)]
        public string Rol { get; set; }
		
		[WcfSerialization::DataMember(Name = "RolID", IsRequired = false, Order = 5)]
        public int? RolID { get; set; }	
	}
}

