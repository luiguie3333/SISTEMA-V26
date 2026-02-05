namespace SISTEMA_V26.FORM
{
    partial class Dashboard
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
            this.BTNinventario = new System.Windows.Forms.Button();
            this.BTNVenta = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNinventario
            // 
            this.BTNinventario.Location = new System.Drawing.Point(322, 122);
            this.BTNinventario.Name = "BTNinventario";
            this.BTNinventario.Size = new System.Drawing.Size(156, 49);
            this.BTNinventario.TabIndex = 0;
            this.BTNinventario.Text = "INVENTARIO";
            this.BTNinventario.UseVisualStyleBackColor = true;
            this.BTNinventario.Click += new System.EventHandler(this.BTNinventario_Click);
            // 
            // BTNVenta
            // 
            this.BTNVenta.Location = new System.Drawing.Point(322, 192);
            this.BTNVenta.Name = "BTNVenta";
            this.BTNVenta.Size = new System.Drawing.Size(150, 47);
            this.BTNVenta.TabIndex = 1;
            this.BTNVenta.Text = "VENTA";
            this.BTNVenta.UseVisualStyleBackColor = true;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(322, 264);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(150, 47);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "SALIR";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNVenta);
            this.Controls.Add(this.BTNinventario);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNinventario;
        private System.Windows.Forms.Button BTNVenta;
        private System.Windows.Forms.Button BTNSalir;
    }
}