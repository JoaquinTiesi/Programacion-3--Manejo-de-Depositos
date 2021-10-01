
namespace Proyecto_Final_Prog_3
{
    partial class Ingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Indentificacion = new System.Windows.Forms.TextBox();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.Ingreso = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su Contraseña:";
            // 
            // Indentificacion
            // 
            this.Indentificacion.Location = new System.Drawing.Point(33, 64);
            this.Indentificacion.Name = "Indentificacion";
            this.Indentificacion.Size = new System.Drawing.Size(197, 20);
            this.Indentificacion.TabIndex = 2;
            // 
            // Contrasenia
            // 
            this.Contrasenia.Location = new System.Drawing.Point(33, 151);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(197, 20);
            this.Contrasenia.TabIndex = 3;
            // 
            // Ingreso
            // 
            this.Ingreso.BackColor = System.Drawing.SystemColors.Info;
            this.Ingreso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Ingreso.Location = new System.Drawing.Point(38, 216);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(75, 34);
            this.Ingreso.TabIndex = 4;
            this.Ingreso.Text = "Ingresar";
            this.Ingreso.UseVisualStyleBackColor = false;
            this.Ingreso.Click += new System.EventHandler(this.Ingreso_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.SystemColors.Info;
            this.Limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Limpiar.Location = new System.Drawing.Point(155, 216);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 34);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnSalir.Location = new System.Drawing.Point(181, 291);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 337);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Ingreso);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.Indentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Indentificacion;
        private System.Windows.Forms.TextBox Contrasenia;
        private System.Windows.Forms.Button Ingreso;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}