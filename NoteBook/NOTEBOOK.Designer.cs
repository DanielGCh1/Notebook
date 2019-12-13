namespace NoteBook
{
    partial class NOTEBOOK
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonCrearNuevoUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(272, 56);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(144, 26);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "NOTEBOOK";
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(318, 117);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(277, 155);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(139, 20);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxUsuario.Leave += new System.EventHandler(this.ObtenerUsuario);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(309, 198);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(64, 13);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(277, 241);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(139, 20);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.Leave += new System.EventHandler(this.ObtenerContraseña);
            // 
            // buttonCrearNuevoUsuario
            // 
            this.buttonCrearNuevoUsuario.Location = new System.Drawing.Point(518, 390);
            this.buttonCrearNuevoUsuario.Name = "buttonCrearNuevoUsuario";
            this.buttonCrearNuevoUsuario.Size = new System.Drawing.Size(112, 30);
            this.buttonCrearNuevoUsuario.TabIndex = 5;
            this.buttonCrearNuevoUsuario.Text = "Nuevo Usuario";
            this.buttonCrearNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Iniciar Sección";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IniciarSeccion);
            // 
            // NOTEBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCrearNuevoUsuario);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelTitulo);
            this.Name = "NOTEBOOK";
            this.Text = "NOTEBOOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonCrearNuevoUsuario;
        private System.Windows.Forms.Button button1;
    }
}

