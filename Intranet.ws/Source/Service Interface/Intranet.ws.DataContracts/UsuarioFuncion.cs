using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Intranet.ws.DataContracts
{
    [DataContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "UsuarioFuncion")]
    public class UsuarioFuncion
    {
        [DataMember(Name = "UsuarioID", IsRequired = false, Order = 0)]
        public int? UsuarioID {get; set;}

        [DataMember(Name = "RolID", IsRequired = false, Order = 1)]
        public int? RolID {get; set;}

        [DataMember(Name = "Rol", IsRequired = false, Order = 2)]
        public string Rol {get; set;}

        [DataMember(Name = "FuncionID", IsRequired = false, Order = 3)]
        public int? FuncionID {get; set;}

        [DataMember(Name = "Funcion", IsRequired = false, Order = 4)]
        public string Funcion {get; set;}

        [DataMember(Name = "FuncionPadreID", IsRequired = false, Order = 5)]
        public int? FuncionPadreID {get; set;}

        [DataMember(Name = "FuncionPadre", IsRequired = false, Order = 6)]
        public string FuncionPadre {get; set;}

        [DataMember(Name = "FuncionDescripcion", IsRequired = false, Order = 7)]
        public string FuncionDescripcion {get; set;}

        [DataMember(Name = "Url", IsRequired = false, Order = 8)]
        public string Url {get; set;}
    }
}
