using System;
using WCF = global::System.Runtime.Serialization;

namespace Intranet.ws.DataContracts
{
    [WCF::DataContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "CountingEntities")]
    public partial class CountingEntities 
	{
        [WCF::DataMember(Name = "NoPaises", IsRequired = false, Order = 0)]
        public Int32? NoPaises { get; set; }
        [WCF::DataMember(Name = "NoEstados", IsRequired = false, Order = 1)]
        public Int32? NoEstados { get; set; }
        [WCF::DataMember(Name = "NoMunicipios", IsRequired = false, Order = 2)]
        public Int32? NoMunicipios { get; set; }
        [WCF::DataMember(Name = "NoCiudades", IsRequired = false, Order = 3)]
        public Int32? NoCiudades { get; set; }
        [WCF::DataMember(Name = "NoCP", IsRequired = false, Order = 4)]
        public Int32? NoCP { get; set; }
	}
}

