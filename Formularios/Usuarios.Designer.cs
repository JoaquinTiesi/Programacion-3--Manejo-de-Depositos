
namespace Proyecto_Final_Prog_3
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnVolver = new System.Windows.Forms.Button();
            this.nUsuario = new System.Windows.Forms.TextBox();
            this.nContrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarUsuario = new System.Windows.Forms.Button();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Info;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnVolver.Location = new System.Drawing.Point(216, 223);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(158, 47);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver a la Pantalla Principal";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // nUsuario
            // 
            this.nUsuario.Location = new System.Drawing.Point(234, 32);
            this.nUsuario.Name = "nUsuario";
            this.nUsuario.Size = new System.Drawing.Size(140, 20);
            this.nUsuario.TabIndex = 18;
            // 
            // nContrasenia
            // 
            this.nContrasenia.Location = new System.Drawing.Point(234, 116);
            this.nContrasenia.Name = "nContrasenia";
            this.nContrasenia.Size = new System.Drawing.Size(140, 20);
            this.nContrasenia.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ingrese nueva Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingrese nueva contraseña:";
            // 
            // btnCargarUsuario
            // 
            this.btnCargarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.btnCargarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnCargarUsuario.Location = new System.Drawing.Point(258, 162);
            this.btnCargarUsuario.Name = "btnCargarUsuario";
            this.btnCargarUsuario.Size = new System.Drawing.Size(87, 30);
            this.btnCargarUsuario.TabIndex = 22;
            this.btnCargarUsuario.Text = "Cargar";
            this.btnCargarUsuario.UseVisualStyleBackColor = false;
            this.btnCargarUsuario.Click += new System.EventHandler(this.btnCargarUsuario_Click);
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpiarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(105, 162);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(87, 30);
            this.btnLimpiarUsuario.TabIndex = 23;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 282);
            this.Controls.Add(this.btnLimpiarUsuario);
            this.Controls.Add(this.btnCargarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nContrasenia);
            this.Controls.Add(this.nUsuario);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox nUsuario;
        private System.Windows.Forms.TextBox nContrasenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarUsuario;
        private System.Windows.Forms.Button btnLimpiarUsuario;
    }
}