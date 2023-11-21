using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoYoyi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario" && txtclave.Text == "123456")
            {
                Menu frminicio = new Menu();
                this.Hide();
                frminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtusuario.Clear();
                txtclave.Clear();
            }
        }
    }
}
