namespace MiPrimerAplicacion
{
    partial class wfFormulario
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
            this.btNombre = new System.Windows.Forms.Button();
            this.lbLuffy = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btNombre
            // 
            this.btNombre.BackColor = System.Drawing.Color.DimGray;
            this.btNombre.Image = global::MiPrimerAplicacion.Properties.Resources.Luffys_flag_icon_icons_com_76118;
            this.btNombre.Location = new System.Drawing.Point(137, 34);
            this.btNombre.Name = "btNombre";
            this.btNombre.Size = new System.Drawing.Size(114, 87);
            this.btNombre.TabIndex = 0;
            this.btNombre.UseVisualStyleBackColor = false;
            this.btNombre.Click += new System.EventHandler(this.btNombre_Click);
            // 
            // lbLuffy
            // 
            this.lbLuffy.AutoSize = true;
            this.lbLuffy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuffy.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbLuffy.Location = new System.Drawing.Point(43, 34);
            this.lbLuffy.Name = "lbLuffy";
            this.lbLuffy.Size = new System.Drawing.Size(59, 24);
            this.lbLuffy.TabIndex = 1;
            this.lbLuffy.Text = "Luffy:";
            this.lbLuffy.MouseLeave += new System.EventHandler(this.lbLuffy_MouseLeave);
            this.lbLuffy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbLuffy_MouseMove);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(47, 221);
            this.txtApellido.MaxLength = 80;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(322, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(47, 269);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombre.Size = new System.Drawing.Size(321, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // wfFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(427, 480);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbLuffy);
            this.Controls.Add(this.btNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFormulario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfFormulario_FormClosing);
            this.Load += new System.EventHandler(this.wfFormulario_Load);
            this.Click += new System.EventHandler(this.wfFormulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNombre;
        private System.Windows.Forms.Label lbLuffy;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

