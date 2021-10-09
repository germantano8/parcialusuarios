using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime UltimoIngreso { get; set; }
        public int DiasUltimoIngreso
        {
            get
            {
                return (DateTime.Today.Subtract(UltimoIngreso)).Days;
            }
        }

        public Usuario() { }

        public Usuario(string clave, string email, string nombreusuario, int tipousuario, DateTime ultimoingreso)
        {
            this.Clave = clave;
            this.Email = email;
            this.NombreUsuario = nombreusuario;
            this.TipoUsuario = tipousuario;
            this.UltimoIngreso = ultimoingreso;
        }
    }
}
