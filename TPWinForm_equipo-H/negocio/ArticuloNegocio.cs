using System;
using System.Collections.Generic;
using System.Text;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
    "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
    "M.Id AS IdMarca, M.Descripcion AS DescripcionMarca, " +
    "C.Id AS IdCategoria, C.Descripcion AS DescripcionCategoria " +
    "From ARTICULOS A, MARCAS M, CATEGORIAS C " +
    "Where M.Id = A.IdMarca And C.Id = A.IdCategoria"
);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DescripcionMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DescripcionCategoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                    "Insert into ARTICULOS " +
                    "(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                    "values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio); " +
                    "Select CAST(SCOPE_IDENTITY() AS int) AS Id"
                );

                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    nuevo.Id = (int)datos.Lector["Id"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
                    "Update ARTICULOS set Codigo = @codigo, Nombre = @nombre, " +
                    "Descripcion = @descripcion, IdMarca = @idMarca, " +
                    "IdCategoria = @idCategoria, Precio = @precio " +
                    "Where Id = @id"
                );

                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.Marca.Id);
                datos.setearParametro("@idCategoria", articulo.Categoria.Id);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(
    "Delete from IMAGENES Where IdArticulo = @id; " +
    "Delete from ARTICULOS Where Id = @id"
);

                datos.setearParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta =
                    "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                    "M.Id AS IdMarca, M.Descripcion AS DescripcionMarca, " +
                    "C.Id AS IdCategoria, C.Descripcion AS DescripcionCategoria " +
                    "From ARTICULOS A, MARCAS M, CATEGORIAS C " +
                    "Where M.Id = A.IdMarca And C.Id = A.IdCategoria And ";

                if (campo == "Código")
                {
                    campo = "A.Codigo";
                }
                else if (campo == "Nombre")
                {
                    campo = "A.Nombre";
                }
                else if (campo == "Marca")
                {
                    campo = "M.Descripcion";
                }
                else if (campo == "Categoría")
                {
                    campo = "C.Descripcion";
                }
                else
                {
                    campo = "A.Precio";
                }

                if (campo == "A.Precio")
                {
                    if (criterio == "Mayor a")
                        consulta += campo + " > " + filtro;
                    else if (criterio == "Menor a")
                        consulta += campo + " < " + filtro;
                    else
                        consulta += campo + " = " + filtro;
                }
                else
                {
                    if (criterio == "Comienza con")
                        consulta += campo + " like '" + filtro + "%'";
                    else if (criterio == "Termina con")
                        consulta += campo + " like '%" + filtro + "'";
                    else
                        consulta += campo + " like '%" + filtro + "%'";
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DescripcionMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DescripcionCategoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
