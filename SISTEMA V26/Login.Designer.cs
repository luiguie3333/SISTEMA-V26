namespace SISTEMA_V26
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContrasena = new System.Windows.Forms.TextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCESO RESTRINGIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE USUARIO ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNSalir);
            this.groupBox1.Controls.Add(this.BTNLimpiar);
            this.groupBox1.Controls.Add(this.BTNIngresar);
            this.groupBox1.Controls.Add(this.TXTContrasena);
            this.groupBox1.Controls.Add(this.TXTUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 215);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR  USUARIO REQUERIDO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE CONTRASEÑA";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUsuario.Location = new System.Drawing.Point(51, 71);
            this.TXTUsuario.Multiline = true;
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(177, 32);
            this.TXTUsuario.TabIndex = 3;
            // 
            // TXTContrasena
            // 
            this.TXTContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTContrasena.Location = new System.Drawing.Point(51, 154);
            this.TXTContrasena.Multiline = true;
            this.TXTContrasena.Name = "TXTContrasena";
            this.TXTContrasena.PasswordChar = '*';
            this.TXTContrasena.Size = new System.Drawing.Size(177, 29);
            this.TXTContrasena.TabIndex = 4;
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(433, 41);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(183, 46);
            this.BTNIngresar.TabIndex = 5;
            this.BTNIngresar.Text = "INGRESAR";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(433, 93);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(183, 46);
            this.BTNLimpiar.TabIndex = 6;
            this.BTNLimpiar.Text = "LIMPIAR";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(433, 145);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(183, 46);
            this.BTNSalir.TabIndex = 7;
            this.BTNSalir.Text = "SALIR";
            this.BTNSalir.UseVisualStyleBackColor = true;
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(591, 18);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(183, 46);
            this.btnProbarConexion.TabIndex = 8;
            this.btnProbarConexion.Text = "conexion a base de datos";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEGURIDAD DEL SISTEMA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.TextBox TXTContrasena;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.Button btnProbarConexion;
    }
}

