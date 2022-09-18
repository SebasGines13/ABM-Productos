namespace TPWinForm_goncalves_gines
{
    partial class frmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.lblTituloListar = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnCancelarListar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gboFiltros = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gboFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloListar
            // 
            this.lblTituloListar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloListar.AutoSize = true;
            this.lblTituloListar.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloListar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloListar.Location = new System.Drawing.Point(12, 24);
            this.lblTituloListar.Name = "lblTituloListar";
            this.lblTituloListar.Size = new System.Drawing.Size(327, 37);
            this.lblTituloListar.TabIndex = 0;
            this.lblTituloListar.Text = "Listado de Articulos";
            this.lblTituloListar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 157);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(748, 339);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnCancelarListar
            // 
            this.btnCancelarListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarListar.Location = new System.Drawing.Point(1027, 521);
            this.btnCancelarListar.Name = "btnCancelarListar";
            this.btnCancelarListar.Size = new System.Drawing.Size(107, 38);
            this.btnCancelarListar.TabIndex = 2;
            this.btnCancelarListar.Text = "Cancelar";
            this.btnCancelarListar.UseVisualStyleBackColor = true;
            this.btnCancelarListar.Click += new System.EventHandler(this.btnCancelarListar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.Transparent;
            this.pbxArticulo.Location = new System.Drawing.Point(766, 96);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(448, 400);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(320, 521);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(103, 521);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(540, 521);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCampo.Location = new System.Drawing.Point(11, 25);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 16);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(641, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 28);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gboFiltros
            // 
            this.gboFiltros.BackColor = System.Drawing.Color.Black;
            this.gboFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gboFiltros.Controls.Add(this.txtFiltroAvanzado);
            this.gboFiltros.Controls.Add(this.cboCriterio);
            this.gboFiltros.Controls.Add(this.lblCriterio);
            this.gboFiltros.Controls.Add(this.cboCampo);
            this.gboFiltros.Controls.Add(this.btnBuscar);
            this.gboFiltros.Controls.Add(this.lblFiltro);
            this.gboFiltros.Controls.Add(this.lblCampo);
            this.gboFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFiltros.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gboFiltros.Location = new System.Drawing.Point(12, 96);
            this.gboFiltros.Name = "gboFiltros";
            this.gboFiltros.Size = new System.Drawing.Size(748, 55);
            this.gboFiltros.TabIndex = 11;
            this.gboFiltros.TabStop = false;
            this.gboFiltros.Text = "Filtros";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(461, 25);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(156, 20);
            this.txtFiltroAvanzado.TabIndex = 18;
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(282, 25);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 14;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCriterio.Location = new System.Drawing.Point(215, 25);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(61, 16);
            this.lblCriterio.TabIndex = 17;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cboCampo
            // 
            this.cboCampo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(77, 25);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFiltro.Location = new System.Drawing.Point(409, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFiltro.TabIndex = 19;
            this.lblFiltro.Text = "Filtro:";
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 576);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCancelarListar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblTituloListar);
            this.Controls.Add(this.gboFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListar";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gboFiltros.ResumeLayout(false);
            this.gboFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloListar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnCancelarListar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gboFiltros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
    }
}