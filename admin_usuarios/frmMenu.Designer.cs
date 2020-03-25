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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Maximizar = new System.Windows.Forms.Button();
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAdministracion = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.btnAdminUs = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelIzquierda.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelAdministracion.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.panelCabecera.Controls.Add(this.pictureBox1);
            this.panelCabecera.Controls.Add(this.btn_Restaurar);
            this.panelCabecera.Controls.Add(this.btn_Minimizar);
            this.panelCabecera.Controls.Add(this.btn_Cerrar);
            this.panelCabecera.Controls.Add(this.btn_Maximizar);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1280, 41);
            this.panelCabecera.TabIndex = 0;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecera_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.Image")));
            this.btn_Restaurar.Location = new System.Drawing.Point(1137, 0);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(69, 36);
            this.btn_Restaurar.TabIndex = 9;
            this.btn_Restaurar.UseVisualStyleBackColor = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1065, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(69, 36);
            this.btn_Minimizar.TabIndex = 10;
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1206, 1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(65, 34);
            this.btn_Cerrar.TabIndex = 11;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(1137, 0);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(69, 36);
            this.btn_Maximizar.TabIndex = 12;
            this.btn_Maximizar.UseVisualStyleBackColor = true;
            this.btn_Maximizar.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.AutoScroll = true;
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.panelIzquierda.Controls.Add(this.panelInicio);
            this.panelIzquierda.Controls.Add(this.button1);
            this.panelIzquierda.Controls.Add(this.panelAdministracion);
            this.panelIzquierda.Controls.Add(this.btnInicio);
            this.panelIzquierda.Controls.Add(this.panelUsuario);
            this.panelIzquierda.Controls.Add(this.btnUsuario);
            this.panelIzquierda.Controls.Add(this.panel1);
            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelIzquierda.Location = new System.Drawing.Point(0, 41);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(282, 679);
            this.panelIzquierda.TabIndex = 1;
            this.panelIzquierda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierda_Paint);
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.button2);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInicio.Location = new System.Drawing.Point(0, 447);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(282, 49);
            this.panelInicio.TabIndex = 6;
            this.panelInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(62, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(282, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar Sesion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 398);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(282, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "INICIO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelAdministracion
            // 
            this.panelAdministracion.Controls.Add(this.button5);
            this.panelAdministracion.Controls.Add(this.button4);
            this.panelAdministracion.Controls.Add(this.button3);
            this.panelAdministracion.Controls.Add(this.btnCerrarS);
            this.panelAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdministracion.Location = new System.Drawing.Point(0, 207);
            this.panelAdministracion.Name = "panelAdministracion";
            this.panelAdministracion.Size = new System.Drawing.Size(282, 191);
            this.panelAdministracion.TabIndex = 4;
            this.panelAdministracion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInicio_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 141);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(282, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Tipos de Productos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 94);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(282, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Productos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 47);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(282, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sub-Categorias";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnCerrarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarS.FlatAppearance.BorderSize = 0;
            this.btnCerrarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.btnCerrarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarS.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarS.Image")));
            this.btnCerrarS.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnCerrarS.Size = new System.Drawing.Size(282, 47);
            this.btnCerrarS.TabIndex = 2;
            this.btnCerrarS.Text = "Categorias ";
            this.btnCerrarS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarS.UseVisualStyleBackColor = false;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 158);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(282, 49);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "ADMINISTRACION";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.btnAdminUs);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 113);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(282, 45);
            this.panelUsuario.TabIndex = 2;
            // 
            // btnAdminUs
            // 
            this.btnAdminUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnAdminUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminUs.FlatAppearance.BorderSize = 0;
            this.btnAdminUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.btnAdminUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.btnAdminUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminUs.Image")));
            this.btnAdminUs.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUs.Name = "btnAdminUs";
            this.btnAdminUs.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAdminUs.Size = new System.Drawing.Size(282, 45);
            this.btnAdminUs.TabIndex = 0;
            this.btnAdminUs.Text = "Admin Usuario";
            this.btnAdminUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminUs.UseVisualStyleBackColor = false;
            this.btnAdminUs.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(191)))), ((int)(((byte)(151)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 64);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(282, 49);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 64);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(822, 679);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelIzquierda);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelIzquierda.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelAdministracion.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelAdministracion;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Maximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInicio;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnAdminUs;
        public System.Windows.Forms.Button btnInicio;
        public System.Windows.Forms.Button btnUsuario;
        public System.Windows.Forms.Button btnCerrarS;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
    }
}

