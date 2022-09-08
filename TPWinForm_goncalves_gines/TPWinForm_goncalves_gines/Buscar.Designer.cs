namespace TPWinForm_goncalves_gines
{
    partial class Buscar
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
            this.lblTituloBuscar = new System.Windows.Forms.Label();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloBuscar
            // 
            this.lblTituloBuscar.AutoSize = true;
            this.lblTituloBuscar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBuscar.Location = new System.Drawing.Point(450, 50);
            this.lblTituloBuscar.Name = "lblTituloBuscar";
            this.lblTituloBuscar.Size = new System.Drawing.Size(197, 32);
            this.lblTituloBuscar.TabIndex = 0;
            this.lblTituloBuscar.Text = "Buscar Articulo";
            this.lblTituloBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Location = new System.Drawing.Point(771, 557);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(105, 43);
            this.btnCancelarBuscar.TabIndex = 1;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click_1);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarBuscar);
            this.Controls.Add(this.lblTituloBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscar";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloBuscar;
        private System.Windows.Forms.Button btnCancelarBuscar;
    }
}