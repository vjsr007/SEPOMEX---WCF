using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intranet.ws.MessageContracts;
using Intranet.ws.FaultContracts;
using Intranet.ws.BusinessLogic;
using WCF = System.ServiceModel;
using Intranet.ws.ServiceContracts;

namespace Intranet.ws.ServiceImplementation
{
    [WCF::ServiceBehavior(Name = "IntranetSR",
    Namespace = "http://Intranet.ws.Model/2015/Catalogos",
    InstanceContextMode = WCF::InstanceContextMode.PerSession,
    ConcurrencyMode = WCF::ConcurrencyMode.Multiple)]
    public partial class IntranetSR : IServiceContract
    {
        #region Seguridad

        public ObtenerUsuarioRes ObtenerUsuario(ObtenerUsuarioReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerUsuario(request.FiltroUsuario);

                return new ObtenerUsuarioRes
                {
                    Usuarios = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public ObtenerUsuarioFuncionesRes ObtenerUsuarioFunciones(ObtenerUsuarioFuncionesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerUsuarioFunciones(request.FiltroUsuario);

                return new ObtenerUsuarioFuncionesRes
                {
                    UsuarioFunciones =  resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion

        public ObtenerCountingEntitiesRes ObtenerCountingEntities(ObtenerCountingEntitiesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerCountingEntities();

                return new ObtenerCountingEntitiesRes
                {
                    CountingEntities = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #region Pais

        public ObtenerPaisesRes ObtenerPaises(ObtenerPaisesReq request) {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerPaises(request.FiltroPais);

                return new ObtenerPaisesRes
                {
                    Paises = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public AgregarPaisesRes AgregarPais(AgregarPaisesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.AgregarPaises(request.FiltroPais);

                return new AgregarPaisesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public EditarPaisesRes EditarPais(EditarPaisesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.EditarPaises(request.FiltroPais);

                return new EditarPaisesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion

        #region Estado

        public ObtenerEstadosRes ObtenerEstados(ObtenerEstadosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerEstados(request.FiltroEstado);

                return new ObtenerEstadosRes
                {
                    Estados = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public AgregarEstadosRes AgregarEstado(AgregarEstadosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.AgregarEstados(request.FiltroEstado);

                return new AgregarEstadosRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public EditarEstadosRes EditarEstado(EditarEstadosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.EditarEstados(request.FiltroEstado);

                return new EditarEstadosRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion

        #region Municipio

        public ObtenerMunicipiosRes ObtenerMunicipios(ObtenerMunicipiosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerMunicipios(request.FiltroMunicipio);

                return new ObtenerMunicipiosRes
                {
                    Municipios = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public AgregarMunicipiosRes AgregarMunicipio(AgregarMunicipiosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.AgregarMunicipios(request.FiltroMunicipio);

                return new AgregarMunicipiosRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public EditarMunicipiosRes EditarMunicipio(EditarMunicipiosReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.EditarMunicipios(request.FiltroMunicipio);

                return new EditarMunicipiosRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion

        #region Ciudad

        public ObtenerCiudadesRes ObtenerCiudades(ObtenerCiudadesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerCiudades(request.FiltroCiudad);

                return new ObtenerCiudadesRes
                {
                    Ciudades = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public AgregarCiudadesRes AgregarCiudad(AgregarCiudadesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.AgregarCiudades(request.FiltroCiudad);

                return new AgregarCiudadesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public EditarCiudadesRes EditarCiudad(EditarCiudadesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.EditarCiudades(request.FiltroCiudad);

                return new EditarCiudadesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion

        #region CodigoPostal

        public ObtenerCodigosPostalesRes ObtenerCodigosPostales(ObtenerCodigosPostalesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.ObtenerCodigosPostales(request.FiltroCodigoPostal);

                return new ObtenerCodigosPostalesRes
                {
                    CodigosPostales = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public AgregarCodigosPostalesRes AgregarCodigoPostal(AgregarCodigosPostalesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.AgregarCodigosPostales(request.FiltroCodigoPostal);

                return new AgregarCodigosPostalesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        public EditarCodigosPostalesRes EditarCodigoPostal(EditarCodigosPostalesReq request)
        {
            try
            {
                var logic = new IntranetLogic();
                var resultado = logic.EditarCodigosPostales(request.FiltroCodigoPostal);

                return new EditarCodigosPostalesRes
                {
                    Respuesta = resultado
                };
            }
            catch (Exception ex)
            {
                var fault = new FaultContracts.Error
                {
                    Mensaje = ex.Message
                };
                throw new WCF.FaultException<FaultContracts.Error>(fault, new WCF.FaultReason(ex.Message));
            }
        }

        #endregion
    }

}