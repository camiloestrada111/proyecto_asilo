namespace MenuAsilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Mini = new System.Windows.Forms.PictureBox();
            this.Maxi = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAdminUs = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panelIzquierda.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(177)))), ((int)(((byte)(247)))));
            this.panelCabecera.Controls.Add(this.Restaurar);
            this.panelCabecera.Controls.Add(this.Mini);
            this.panelCabecera.Controls.Add(this.Maxi);
            this.panelCabecera.Controls.Add(this.Exit);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1180, 41);
            this.panelCabecera.TabIndex = 0;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1069, 0);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(43, 41);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 8;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Mini
            // 
            this.Mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mini.Image = ((System.Drawing.Image)(resources.GetObject("Mini.Image")));
            this.Mini.Location = new System.Drawing.Point(1016, 0);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(41, 39);
            this.Mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mini.TabIndex = 4;
            this.Mini.TabStop = false;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // Maxi
            // 
            this.Maxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maxi.Image = ((System.Drawing.Image)(resources.GetObject("Maxi.Image")));
            this.Maxi.Location = new System.Drawing.Point(1069, 2);
            this.Maxi.Name = "Maxi";
            this.Maxi.Size = new System.Drawing.Size(41, 39);
            this.Maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maxi.TabIndex = 3;
            this.Maxi.TabStop = false;
            this.Maxi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1121, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(47, 42);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.AutoScroll = true;
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(177)))), ((int)(((byte)(247)))));
            this.panelIzquierda.Controls.Add(this.panelInicio);
            this.panelIzquierda.Controls.Add(this.btnInicio);
            this.panelIzquierda.Controls.Add(this.panelUsuario);
            this.panelIzquierda.Controls.Add(this.btnUsuario);
            this.panelIzquierda.Controls.Add(this.panel1);
            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierda.Location = new System.Drawing.Point(0, 41);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(97, 679);
            this.panelIzquierda.TabIndex = 1;
            this.panelIzquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierda_Paint);
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.btnCerrarS);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.Location = new System.Drawing.Point(0, 217);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(97, 46);
            this.panelInicio.TabIndex = 4;
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.btnCerrarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarS.FlatAppearance.BorderSize = 0;
            this.btnCerrarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnCerrarS.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btnCerrarS.Size = new System.Drawing.Size(97, 46);
            this.btnCerrarS.TabIndex = 2;
            this.btnCerrarS.Text = "Cerrar Sesion";
            this.btnCerrarS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarS.UseVisualStyleBackColor = false;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 166);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(97, 51);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnAdminUs);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 121);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(97, 45);
            this.panelUsuario.TabIndex = 2;
            // 
            // btnAdminUs
            // 
            this.btnAdminUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.btnAdminUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminUs.FlatAppearance.BorderSize = 0;
            this.btnAdminUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdminUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAdminUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUs.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUs.Name = "btnAdminUs";
            this.btnAdminUs.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btnAdminUs.Size = new System.Drawing.Size(97, 45);
            this.btnAdminUs.TabIndex = 0;
            this.btnAdminUs.Text = "Admin Usuario";
            this.btnAdminUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUs.UseVisualStyleBackColor = false;
            this.btnAdminUs.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 64);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(97, 57);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 64);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 720);
            this.Controls.Add(this.panelIzquierda);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panelIzquierda.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.PictureBox Maxi;
        private System.Windows.Forms.PictureBox Mini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Button btnAdminUs;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Button btnCerrarS;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

