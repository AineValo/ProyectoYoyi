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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            {
                if (this.PanelCentro.Controls.Count > 0)
                    this.PanelCentro.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelCentro.Controls.Add(fh);
                this.PanelCentro.Tag = fh;
                fh.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PanelCentro_Paint(object sender, PaintEventArgs e)
        {

        }
        //MOverse en el menu
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Postres());
        }

        private void btnCarrito_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Carrito());
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new bebidas());
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new comida());
        }

        private void btncombo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new combo());
        }
    }
}
