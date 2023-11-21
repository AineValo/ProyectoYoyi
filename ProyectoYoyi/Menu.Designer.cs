
namespace ProyectoYoyi
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelCentro = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnPostres = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btncombo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnCarrito);
            this.panel1.Controls.Add(this.btnPostres);
            this.panel1.Controls.Add(this.btnComida);
            this.panel1.Controls.Add(this.btnBebidas);
            this.panel1.Controls.Add(this.btncombo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 690);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 114);
            this.panel2.TabIndex = 1;
            // 
            // PanelCentro
            // 
            this.PanelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentro.Location = new System.Drawing.Point(304, 114);
            this.PanelCentro.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCentro.Name = "PanelCentro";
            this.PanelCentro.Size = new System.Drawing.Size(1075, 576);
            this.PanelCentro.TabIndex = 2;
            this.PanelCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentro_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ProyectoYoyi.Properties.Resources.EQUIS;
            this.pictureBox3.Location = new System.Drawing.Point(1023, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ProyectoYoyi.Properties.Resources.minimizar;
            this.pictureBox2.Location = new System.Drawing.Point(979, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Image = global::ProyectoYoyi.Properties.Resources.arr1;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(0, 505);
            this.btnCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(300, 92);
            this.btnCarrito.TabIndex = 5;
            this.btnCarrito.Text = "Carrito ";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click_1);
            // 
            // btnPostres
            // 
            this.btnPostres.FlatAppearance.BorderSize = 0;
            this.btnPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostres.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostres.Image = global::ProyectoYoyi.Properties.Resources.Diseño_sin_título__4_2;
            this.btnPostres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostres.Location = new System.Drawing.Point(0, 410);
            this.btnPostres.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostres.Name = "btnPostres";
            this.btnPostres.Size = new System.Drawing.Size(300, 87);
            this.btnPostres.TabIndex = 4;
            this.btnPostres.Text = "Postres";
            this.btnPostres.UseVisualStyleBackColor = true;
            this.btnPostres.Click += new System.EventHandler(this.btnPostres_Click);
            // 
            // btnComida
            // 
            this.btnComida.FlatAppearance.BorderSize = 0;
            this.btnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComida.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Image = global::ProyectoYoyi.Properties.Resources.Diseño_sin_título__2_;
            this.btnComida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComida.Location = new System.Drawing.Point(0, 247);
            this.btnComida.Margin = new System.Windows.Forms.Padding(4);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(300, 74);
            this.btnComida.TabIndex = 3;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnBebidas
            // 
            this.btnBebidas.FlatAppearance.BorderSize = 0;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.Image = global::ProyectoYoyi.Properties.Resources.Diseño_sin_título__3_1;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.Location = new System.Drawing.Point(0, 329);
            this.btnBebidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(300, 74);
            this.btnBebidas.TabIndex = 2;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btncombo
            // 
            this.btncombo.FlatAppearance.BorderSize = 0;
            this.btncombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncombo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncombo.Image = global::ProyectoYoyi.Properties.Resources.Diseño_sin_título__5_;
            this.btncombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncombo.Location = new System.Drawing.Point(0, 153);
            this.btncombo.Margin = new System.Windows.Forms.Padding(4);
            this.btncombo.Name = "btncombo";
            this.btncombo.Size = new System.Drawing.Size(300, 87);
            this.btncombo.TabIndex = 1;
            this.btncombo.Text = "Combo";
            this.btncombo.UseVisualStyleBackColor = true;
            this.btncombo.Click += new System.EventHandler(this.btncombo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoYoyi.Properties.Resources.Burguer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 690);
            this.Controls.Add(this.PanelCentro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnPostres;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btncombo;
        private System.Windows.Forms.Panel PanelCentro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

