namespace admin_us
{
    partial class frmMessageBoxErrorYaExisteElQueQuiereAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBoxErrorYaExisteElQueQuiereAgregar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 22);
            this.panel2.TabIndex = 19;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(341, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(65, 22);
            this.btn_Cerrar.TabIndex = 21;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInicio.Location = new System.Drawing.Point(34, 59);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(325, 25);
            this.lblInicio.TabIndex = 21;
            this.lblInicio.Text = "Error ya existe el que quiere agregar";
            // 
            // frmMessageBoxErrorYaExisteElQueQuiereAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 120);
            this.ControlBox = false;
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmMessageBoxErrorYaExisteElQueQuiereAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lblInicio;
    }
}