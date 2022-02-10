namespace SistemaDeArchivo
{
    partial class Form1
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
            this.btnAbriDocumento = new System.Windows.Forms.Button();
            this.btnAbrirFolder = new System.Windows.Forms.Button();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbriDocumento
            // 
            this.btnAbriDocumento.Location = new System.Drawing.Point(12, 12);
            this.btnAbriDocumento.Name = "btnAbriDocumento";
            this.btnAbriDocumento.Size = new System.Drawing.Size(131, 23);
            this.btnAbriDocumento.TabIndex = 0;
            this.btnAbriDocumento.Text = "Abrir documento";
            this.btnAbriDocumento.UseVisualStyleBackColor = true;
            this.btnAbriDocumento.Click += new System.EventHandler(this.btnAbriDocumento_Click);
            // 
            // btnAbrirFolder
            // 
            this.btnAbrirFolder.Location = new System.Drawing.Point(12, 41);
            this.btnAbrirFolder.Name = "btnAbrirFolder";
            this.btnAbrirFolder.Size = new System.Drawing.Size(126, 37);
            this.btnAbrirFolder.TabIndex = 1;
            this.btnAbrirFolder.Text = "Abrir carpeta";
            this.btnAbrirFolder.UseVisualStyleBackColor = true;
            this.btnAbrirFolder.Click += new System.EventHandler(this.btnAbrirFolder_Click);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.ItemHeight = 16;
            this.lstArchivos.Location = new System.Drawing.Point(12, 107);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(120, 132);
            this.lstArchivos.TabIndex = 2;
            // 
            // lblRuta
            // 
            this.lblRuta.Location = new System.Drawing.Point(12, 81);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(732, 23);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.btnAbrirFolder);
            this.Controls.Add(this.btnAbriDocumento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbriDocumento;
        private System.Windows.Forms.Button btnAbrirFolder;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.Label lblRuta;
    }
}

