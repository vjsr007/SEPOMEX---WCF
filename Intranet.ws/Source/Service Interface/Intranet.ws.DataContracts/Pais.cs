using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wcf = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
    [Wcf::DataContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "Pais")]
	public partial class Pais
    {
		[Wcf::DataMember(Name = "PaisID", IsRequired = false, Order = 0)]
        public int? PaisID { get; set; }	

        [Wcf::DataMember(Name = "Nombre", IsRequired = false, Order = 1)]
        public string Nombre { get; set; }	

        [Wcf::DataMember(Name = "Codigo", IsRequired = false, Order = 2)]
        public string Codigo { get; set; }		
        
        [Wcf::DataMember(Name = "Moneda", IsRequired = false, Order = 3)]
        public string Moneda { get; set; }		
            
        [Wcf::DataMember(Name = "CodMoneda", IsRequired = false, Order = 4)]
        public string CodMoneda { get; set; }	
            
        [Wcf::DataMember(Name = "FechaUltimaModificacion", IsRequired = false, Order = 5)]
        public DateTime? FechaUltimaModificacion	 { get; set; }	
            
        [Wcf::DataMember(Name = "UsuarioID", IsRequired = false, Order = 6)]
        public int? UsuarioID	 { get; set; }	
            
        [Wcf::DataMember(Name = "Activo", IsRequired = false, Order = 7)]
        public bool? Activo { get; set; }	
    }
}
