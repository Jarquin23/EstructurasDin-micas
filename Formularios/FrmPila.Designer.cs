namespace EstructurasDinámicas.Formularios
{
    partial class FrmPila
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnMostrarUltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(80, 34);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(186, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Location = new System.Drawing.Point(30, 104);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(55, 13);
            this.lblPila.TabIndex = 3;
            this.lblPila.Text = "Pila vacía";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(186, 73);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(125, 44);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnMostrarUltimo
            // 
            this.btnMostrarUltimo.Location = new System.Drawing.Point(186, 124);
            this.btnMostrarUltimo.Name = "btnMostrarUltimo";
            this.btnMostrarUltimo.Size = new System.Drawing.Size(125, 64);
            this.btnMostrarUltimo.TabIndex = 5;
            this.btnMostrarUltimo.Text = "Mostrar último";
            this.btnMostrarUltimo.UseVisualStyleBackColor = true;
            this.btnMostrarUltimo.Click += new System.EventHandler(this.btnMostrarUltimo_Click);
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.btnMostrarUltimo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "FrmPila";
            this.Text = "PilaEnteros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnMostrarUltimo;
    }
}