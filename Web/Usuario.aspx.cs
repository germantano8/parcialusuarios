using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Entidades.Usuario usuario = new Entidades.Usuario();
            try
            {
                usuario = Negocio.Usuario.RecuperarUno(txtNombreUsuario.Text);

                lblEmail.Text = usuario.Email;
                lblTipoUsuario.Text = usuario.TipoUsuario.ToString();
                lblUltimoIngreso.Text = usuario.UltimoIngreso.ToString();
                lblDias.Text = usuario.DiasUltimoIngreso.ToString();
            }catch(Exception ex)
            {
                lblInforma.Text = ex.Message;
            }            
        }
    }
}