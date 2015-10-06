using System;
using System.Net.Security;
using WCF = global::System.ServiceModel;
using Intranet.ws.MessageContracts;

namespace Intranet.ws.ServiceContracts
{
	[WCF::ServiceContract(Namespace = "http://Intranet.ws.Model/2015/Catalogos", Name = "ServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None )]
	public partial interface IServiceContract 
	{
		[WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
		[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerUsuario", ProtectionLevel = ProtectionLevel.None)]
		ObtenerUsuarioRes ObtenerUsuario(ObtenerUsuarioReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerCountingEntities", ProtectionLevel = ProtectionLevel.None)]
        ObtenerCountingEntitiesRes ObtenerCountingEntities(ObtenerCountingEntitiesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerPaises", ProtectionLevel = ProtectionLevel.None)]
        ObtenerPaisesRes ObtenerPaises(ObtenerPaisesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/AgregarPais", ProtectionLevel = ProtectionLevel.None)]
        AgregarPaisesRes AgregarPais(AgregarPaisesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/EditarPais", ProtectionLevel = ProtectionLevel.None)]
        EditarPaisesRes EditarPais(EditarPaisesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerEstados", ProtectionLevel = ProtectionLevel.None)]
        ObtenerEstadosRes ObtenerEstados(ObtenerEstadosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/AgregarEstado", ProtectionLevel = ProtectionLevel.None)]
        AgregarEstadosRes AgregarEstado(AgregarEstadosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/EditarEstado", ProtectionLevel = ProtectionLevel.None)]
        EditarEstadosRes EditarEstado(EditarEstadosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerMunicipios", ProtectionLevel = ProtectionLevel.None)]
        ObtenerMunicipiosRes ObtenerMunicipios(ObtenerMunicipiosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/AgregarMunicipio", ProtectionLevel = ProtectionLevel.None)]
        AgregarMunicipiosRes AgregarMunicipio(AgregarMunicipiosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/EditarMunicipio", ProtectionLevel = ProtectionLevel.None)]
        EditarMunicipiosRes EditarMunicipio(EditarMunicipiosReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerCiudades", ProtectionLevel = ProtectionLevel.None)]
        ObtenerCiudadesRes ObtenerCiudades(ObtenerCiudadesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/AgregarCiudad", ProtectionLevel = ProtectionLevel.None)]
        AgregarCiudadesRes AgregarCiudad(AgregarCiudadesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/EditarCiudad", ProtectionLevel = ProtectionLevel.None)]
        EditarCiudadesRes EditarCiudad(EditarCiudadesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerCodigosPostales", ProtectionLevel = ProtectionLevel.None)]
        ObtenerCodigosPostalesRes ObtenerCodigosPostales(ObtenerCodigosPostalesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/AgregarCodigoPostal", ProtectionLevel = ProtectionLevel.None)]
        AgregarCodigosPostalesRes AgregarCodigoPostal(AgregarCodigosPostalesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/EditarCodigoPostal", ProtectionLevel = ProtectionLevel.None)]
        EditarCodigosPostalesRes EditarCodigoPostal(EditarCodigosPostalesReq request);

        [WCF::FaultContract(typeof(Intranet.ws.FaultContracts.Error))]
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://Intranet.ws.Model/2015/Catalogos/ServiceContract/ObtenerUsuarioFunciones", ProtectionLevel = ProtectionLevel.None)]
        ObtenerUsuarioFuncionesRes ObtenerUsuarioFunciones(ObtenerUsuarioFuncionesReq request);
	}
}