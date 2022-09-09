namespace TPWinForm_goncalves_gines
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImagenURL = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptarAgregar = new System.Windows.Forms.Button();
            this.btnCancelarAgregar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloAgregar
            // 
            resources.ApplyResources(this.lblTituloAgregar, "lblTituloAgregar");
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtCodigo
            // 
            resources.ApplyResources(this.txtCodigo, "txtCodigo");
            this.txtCodigo.Name = "txtCodigo";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(this.txtDescripcion, "txtDescripcion");
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // txtImagenURL
            // 
            resources.ApplyResources(this.txtImagenURL, "txtImagenURL");
            this.txtImagenURL.Name = "txtImagenURL";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            resources.ApplyResources(this.cbxMarca, "cbxMarca");
            this.cbxMarca.Name = "cbxMarca";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCategoria, "cbxCategoria");
            this.cbxCategoria.Name = "cbxCategoria";
            // 
            // btnAceptarAgregar
            // 
            resources.ApplyResources(this.btnAceptarAgregar, "btnAceptarAgregar");
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = true;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // btnCancelarAgregar
            // 
            resources.ApplyResources(this.btnCancelarAgregar, "btnCancelarAgregar");
            this.btnCancelarAgregar.Name = "btnCancelarAgregar";
            this.btnCancelarAgregar.UseVisualStyleBackColor = true;
            this.btnCancelarAgregar.Click += new System.EventHandler(this.btnCancelarAgregar_Click_1);
            // 
            // lblCategoria
            // 
            resources.ApplyResources(this.lblCategoria, "lblCategoria");
            this.lblCategoria.Name = "lblCategoria";
            // 
            // lblMarca
            // 
            resources.ApplyResources(this.lblMarca, "lblMarca");
            this.lblMarca.Name = "lblMarca";
            // 
            // frmAgregar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlBox = false;
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCancelarAgregar);
            this.Controls.Add(this.btnAceptarAgregar);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtImagenURL);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregar";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImagenURL;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAceptarAgregar;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
    }
}