using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Usuario : Base
    {
        public List<Entidades.Usuario> RecuperarTodos()
        {
            List<Entidades.Usuario> listaUsuarios = new List<Entidades.Usuario>();

            string query = "select * from Usuarios";

            SqlCommand comando = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();

                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.Usuario usuario = new Entidades.Usuario();

                    usuario.Clave = (string)dr["Clave"];
                    usuario.Email = (string)dr["Email"];
                    usuario.UltimoIngreso = (DateTime)dr["UltimoIngreso"];
                    usuario.NombreUsuario = (string)dr["NombreUsuario"];
                    usuario.TipoUsuario = (int)dr["TipoUsuario"];

                    listaUsuarios.Add(usuario);
                }
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Se produjo un error al recuperar los datos", e);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return listaUsuarios;
        }

        public Entidades.Usuario RecuperarUno(string nombreusuario)
        {
            Entidades.Usuario usuario = new Entidades.Usuario();

            List<Entidades.Usuario> listaUsuarios = RecuperarTodos();

            usuario = listaUsuarios.FirstOrDefault(u => u.NombreUsuario.Equals(nombreusuario));
            
            return usuario;
        }

        public void Agregar(Entidades.Usuario usuario)
        {
            string query = "insert into Usuarios values (@usuario, @clave, @tipousuario, @email, @ultimoingreso)";

            SqlCommand comando = new SqlCommand(query, conexion);

            try
            {
                conexion.Open();

                comando.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@tipousuario", usuario.TipoUsuario);
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@ultimoingreso", usuario.UltimoIngreso);

                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Exception ex = new Exception("No se pudo agregar el usuario", e);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
