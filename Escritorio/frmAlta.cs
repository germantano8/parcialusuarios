using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<String> campos = new List<String>
            {
                txtClave.Text,
                txtEmail.Text,
                txtNombreUsuario.Text,
                txtTipoUsuario.Text,
            };

            if(Negocio.Validaciones.vacios(campos) && Negocio.Validaciones.esMailValido(txtEmail.Text))
            {
                Entidades.Usuario usuario = new Entidades.Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    Email = txtEmail.Text,
                    Clave = txtClave.Text,
                    TipoUsuario = int.Parse(txtTipoUsuario.Text),
                    UltimoIngreso = calendar.Value,
                };
                try
                {
                    Negocio.Usuario.Agregar(usuario);
                    MessageBox.Show("Usuario agregado correctamente");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente");
            }
        }
    }
}
