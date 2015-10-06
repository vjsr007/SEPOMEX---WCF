using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wcf = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
    [Wcf::DataContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "CodigoPostal")]
    public partial class CodigoPostal
    {
        [Wcf::DataMember(Name = "CodigoPostalID", IsRequired = false, Order = 0)]
        public int? CodigoPostalID { get; set; }

        [Wcf::DataMember(Name = "codigoPostal", IsRequired = false, Order = 1)]
        public string codigoPostal { get; set; }

        [Wcf::DataMember(Name = "MunicipioID", IsRequired = false, Order = 2)]
        public int? MunicipioID { get; set; }

        [Wcf::DataMember(Name = "Municipio", IsRequired = false, Order = 3)]
        public string Municipio { get; set; }

        [Wcf::DataMember(Name = "CiudadID", IsRequired = false, Order = 4)]
        public int? CiudadID { get; set; }

        [Wcf::DataMember(Name = "Ciudad", IsRequired = false, Order = 5)]
        public string Ciudad { get; set; }

        [Wcf::DataMember(Name = "Asentamiento", IsRequired = false, Order = 6)]
        public string Asentamiento { get; set; }

        [Wcf::DataMember(Name = "TipoAsentamiento", IsRequired = false, Order = 7)]
        public string TipoAsentamiento { get; set; }

        [Wcf::DataMember(Name = "Zona", IsRequired = false, Order = 8)]
        public string Zona { get; set; }

        [Wcf::DataMember(Name = "FechaUltimaModificacion", IsRequired = false, Order = 9)]
        public DateTime? FechaUltimaModificacion { get; set; }

        [Wcf::DataMember(Name = "UsuarioID", IsRequired = false, Order = 10)]
        public int? UsuarioID { get; set; }

        [Wcf::DataMember(Name = "Activo", IsRequired = false, Order = 11)]
        public bool? Activo { get; set; }

        [Wcf::DataMember(Name = "EstadoID", IsRequired = false, Order = 12)]
        public int? EstadoID { get; set; }

        [Wcf::DataMember(Name = "Estado", IsRequired = false, Order = 13)]
        public string Estado { get; set; }

        [Wcf::DataMember(Name = "PaisID", IsRequired = false, Order = 14)]
        public int? PaisID { get; set; }

        [Wcf::DataMember(Name = "Pais", IsRequired = false, Order = 15)]
        public string Pais { get; set; }
    }
}