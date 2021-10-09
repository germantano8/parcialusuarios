using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        static public List<Entidades.Usuario> RecuperarTodos()
        {
            Datos.Usuario datosUsuario = new Datos.Usuario();
            return datosUsuario.RecuperarTodos();
        }

        static public Entidades.Usuario RecuperarUno(string nombreusuario)
        {
            if (String.IsNullOrEmpty(nombreusuario))
            {
                throw new Exception("El nombre de usuario es nulo");
            }

            Datos.Usuario datosUsuario = new Datos.Usuario();
            return datosUsuario.RecuperarUno(nombreusuario);
        }

        static public void Agregar(Entidades.Usuario usuario)
        {
            Datos.Usuario datosUsuario = new Datos.Usuario();
            datosUsuario.Agregar(usuario);
        }
    }

    public class Validaciones
    {
        static public bool esMailValido(string mail)
        {
            string patron = @"^([0-9A-Za-z])+@([0-9A-Za-z])+\.([A-Za-z]){2,3}$";

            if(Regex.IsMatch(mail, patron))
            {
                return true;
            }

            return false;
        }

        static public bool vacios(List<String> campos)
        {
            foreach (var c in campos)
            {
                if (String.IsNullOrEmpty(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
