using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intranet.ws.DataContracts;
using Intranet.ws.DataAccess;

namespace Intranet.ws.BusinessLogic
{
    public class IntranetLogic
    {
        #region Seguridad

        public Usuarios ObtenerUsuario(Usuario f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                Usuarios Usuarios = new Usuarios();
                var usuarios =  data
                                .spObtenerUsuario(f.Nombre, f.Pass)
                                .Select(u =>
                                    new Usuario
                                    {
                                        Nombre = u.Nombre,
                                        UsuarioID = u.UsuarioID,
                                        Rol = u.Rol,
                                        RolID = u.RolID
                                    });

                Usuarios.AddRange(usuarios);

                return Usuarios;
            }
        }

        public UsuarioFunciones ObtenerUsuarioFunciones(Usuario f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                UsuarioFunciones UsuarioFunciones = new UsuarioFunciones();
                var usuarioFunciones = data
                                .spObtenerUsuarioFunciones(f.UsuarioID)
                                .Select(fn =>
                                    new UsuarioFuncion
                                    {
                                        UsuarioID = fn.UsuarioID,
                                        RolID = fn.RolID,
                                        Rol = fn.Rol,
                                        FuncionID = fn.FuncionID,
                                        Funcion = fn.Funcion,
                                        FuncionPadreID = fn.FuncionPadreID,
                                        FuncionPadre = fn.FuncionPadre,
                                        FuncionDescripcion = fn.FuncionDescripcion,
                                        Url = fn.Url
                                    });

                UsuarioFunciones.AddRange(usuarioFunciones);

                return UsuarioFunciones;
            }
        }

        #endregion

        public CountingEntities ObtenerCountingEntities()
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var countingEntities = data
                                .spCountingEntities()
                                .Select(c =>
                                    new CountingEntities
                                    {
                                        NoCiudades = c.NoCiudades,
                                        NoEstados = c.NoEstados,
                                        NoMunicipios = c.NoMunicipios,
                                        NoPaises = c.NoPaises,
                                        NoCP = c.NoCP
                                    });

                return countingEntities.FirstOrDefault();
            }
        }

        #region Pais

        public Paises ObtenerPaises(Pais f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                Paises Paises = new Paises();
                var paises = data
                                .spObtenerPaises(f.Activo, f.Nombre, f.Codigo, f.PaisID)
                                .Select(p =>
                                    new Pais
                                    {
                                        Activo = p.Activo,
                                        Codigo = p.Codigo,
                                        CodMoneda = p.CodMoneda,
                                        FechaUltimaModificacion = p.FechaUltimaModificacion,
                                        Moneda = p.Moneda,
                                        Nombre = p.Nombre,
                                        PaisID = p.PaisID,
                                        UsuarioID = p.UsuarioID
                                    });

                Paises.AddRange(paises);

                return Paises;
            }
        }

        public int? AgregarPaises(Pais f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var paises = data.spAgregarPais(f.Nombre, f.Codigo, f.Moneda, f.CodMoneda, f.UsuarioID);

                return paises;
            }
        }

        public int? EditarPaises(Pais f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var paises = data.spEditarPais(f.PaisID, f.Nombre, f.Codigo, f.Moneda, f.CodMoneda, f.UsuarioID, f.Activo);

                return paises;
            }
        }

        #endregion

        #region Estado
        public Estados ObtenerEstados(Estado f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                Estados Estados = new Estados();
                var estados = data
                                .spObtenerEstados(f.EstadoID, f.Codigo, f.Nombre, f.PaisID, f.Activo)
                                .Select(p =>
                                    new Estado
                                    {
                                        Activo = p.Activo,
                                        Codigo = p.Codigo,
                                        FechaUltimaModificacion = p.FechaUltimaModificacion,
                                        Nombre = p.Nombre,
                                        EstadoID = p.EstadoID,
                                        UsuarioID = p.UsuarioID,
                                        Pais = p.Pais,
                                        PaisID = p.PaisID
                                    });

                Estados.AddRange(estados);

                return Estados;
            }
        }

        public int? AgregarEstados(Estado f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var estados = data.spAgregarEstados(f.Codigo, f.Nombre,f.PaisID, f.UsuarioID, f.Activo);

                return estados;
            }
        }

        public int? EditarEstados(Estado f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var estados = data.spEditarEstados(f.EstadoID, f.Codigo, f.Nombre,f.PaisID, f.UsuarioID, f.Activo);

                return estados;
            }
        }

        #endregion

        #region Municipio
        public Municipios ObtenerMunicipios(Municipio f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                Municipios Municipios = new Municipios();
                var municipios = data
                                .spObtenerMunicipios(f.MunicipioID, f.Codigo, f.Nombre, f.EstadoID, f.Activo, f.PaisID)
                                .Select(p =>
                                    new Municipio
                                    {
                                        Activo = p.Activo,
                                        Codigo = p.Codigo,
                                        FechaUltimaModificacion = p.FechaUltimaModificacion,
                                        Nombre = p.Nombre,
                                        MunicipioID = p.MunicipioID,
                                        UsuarioID = p.UsuarioID,
                                        Pais = p.Pais,
                                        PaisID = p.PaisID,
                                        Estado = p.Estado,
                                        EstadoID = p.EstadoID
                                    });

                Municipios.AddRange(municipios);

                return Municipios;
            }
        }

        public int? AgregarMunicipios(Municipio f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var municipios = data.spAgregarMunicipios(f.Codigo, f.Nombre, f.EstadoID, f.Activo, f.UsuarioID);

                return municipios;
            }
        }

        public int? EditarMunicipios(Municipio f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var municipios = data.spEditarMunicipios(f.MunicipioID, f.Codigo, f.Nombre, f.EstadoID, f.Activo, f.UsuarioID);

                return municipios;
            }
        }

        #endregion

        #region Ciudad
        public Ciudades ObtenerCiudades(Ciudad f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                Ciudades Ciudades = new Ciudades();
                var ciudades = data
                                .spObtenerCiudades(f.CiudadID, f.MunicipioID, f.Nombre, f.EstadoID, f.Activo, f.PaisID)
                                .Select(p =>
                                    new Ciudad
                                    {
                                        Activo = p.Activo,
                                        FechaUltimaModificacion = p.FechaUltimaModificacion,
                                        Nombre = p.Nombre,
                                        CiudadID = p.CiudadID,
                                        UsuarioID = p.UsuarioID,
                                        Pais = p.Pais,
                                        PaisID = p.PaisID,
                                        Estado = p.Estado,
                                        EstadoID = p.EstadoID,
                                        MunicipioID = p.MunicipioID,
                                        Municipio = p.Municipio
                                    });

                Ciudades.AddRange(ciudades);

                return Ciudades;
            }
        }

        public int? AgregarCiudades(Ciudad f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var ciudades = data.spAgregarCiudades(f.MunicipioID, f.Nombre, f.EstadoID, f.Activo, f.UsuarioID);

                return ciudades;
            }
        }

        public int? EditarCiudades(Ciudad f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var ciudades = data.spEditarCiudades(f.CiudadID, f.MunicipioID, f.Nombre, f.EstadoID, f.Activo, f.UsuarioID);

                return ciudades;
            }
        }

        #endregion

        #region CodigoPostal
        public CodigosPostales ObtenerCodigosPostales(CodigoPostal f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                CodigosPostales CodigosPostales = new CodigosPostales();
                var codigosPostales = data
                                .spObtenerCodigosPostales(f.codigoPostal, f.TipoAsentamiento, f.Asentamiento,f.Zona,f.MunicipioID, f.CiudadID,f.EstadoID,f.Activo,f.PaisID)
                                .Select(p =>
                                    new CodigoPostal
                                    {
                                        Activo = p.Activo,
                                        FechaUltimaModificacion = p.FechaUltimaModificacion,
                                        CodigoPostalID = p.CodigoPostalID,
                                        UsuarioID = p.UsuarioID,
                                        Pais = p.Pais,
                                        PaisID = p.PaisID,
                                        Estado = p.Estado,
                                        EstadoID = p.EstadoID,
                                        MunicipioID = p.MunicipioID,
                                        Municipio = p.Municipio,
                                        Asentamiento = p.Asentamiento,
                                        TipoAsentamiento = p.TipoAsentamiento,
                                        Ciudad = p.Ciudad,
                                        CiudadID = p.CiudadID,
                                        codigoPostal = p.CodigoPostal,
                                        Zona = p.Zona
                                    });

                CodigosPostales.AddRange(codigosPostales);

                return CodigosPostales;
            }
        }

        public int? AgregarCodigosPostales(CodigoPostal f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var codigosPostales = data.spAgregarCodigosPostales(f.codigoPostal, f.TipoAsentamiento, f.Asentamiento, f.Zona,f.MunicipioID, f.CiudadID, f.Activo, f.UsuarioID);

                return codigosPostales;
            }
        }

        public int? EditarCodigosPostales(CodigoPostal f)
        {
            using (var data = IntranetDataContext.GetDataContext())
            {
                var codigosPostales = data.spEditarCodigosPostales(f.CodigoPostalID, f.codigoPostal, f.TipoAsentamiento, f.Asentamiento, f.Zona, f.MunicipioID, f.CiudadID, f.Activo, f.UsuarioID);

                return codigosPostales;
            }
        }

        #endregion
    }
}