
namespace Proyecto_Final_Prog_3
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.Info;
            this.btnBusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnBusqueda.Location = new System.Drawing.Point(243, 178);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(154, 74);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdministracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAdministracion.Location = new System.Drawing.Point(40, 178);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(154, 74);
            this.btnAdministracion.TabIndex = 2;
            this.btnAdministracion.Text = "Administrar Depositos";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnSalir.Location = new System.Drawing.Point(243, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 74);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar Sesion";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.SystemColors.Info;
            this.btnIngresos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnIngresos.Location = new System.Drawing.Point(40, 71);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(154, 74);
            this.btnIngresos.TabIndex = 4;
            this.btnIngresos.Text = "Ingreso";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administrador de depositos 3000!";
            // 
            // btnEgresos
            // 
            this.btnEgresos.BackColor = System.Drawing.SystemColors.Info;
            this.btnEgresos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnEgresos.Location = new System.Drawing.Point(243, 71);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(154, 74);
            this.btnEgresos.TabIndex = 6;
            this.btnEgresos.Text = "Egreso";
            this.btnEgresos.UseVisualStyleBackColor = false;
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdministrarUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(40, 296);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(154, 74);
            this.btnAdministrarUsuarios.TabIndex = 7;
            this.btnAdministrarUsuarios.Text = "Administrar Usuarios";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = false;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 399);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnEgresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEgresos;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
    }
}