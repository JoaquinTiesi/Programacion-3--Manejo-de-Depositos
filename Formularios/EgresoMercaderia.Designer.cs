
namespace Proyecto_Final_Prog_3
{
    partial class EgresoMercaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgresoMercaderia));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoBarrasEgreso = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ComboDeposito = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnBorrar.Location = new System.Drawing.Point(46, 194);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 47);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Eliminar Mercaderia";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese codigo de barras:";
            // 
            // CodigoBarrasEgreso
            // 
            this.CodigoBarrasEgreso.Location = new System.Drawing.Point(46, 57);
            this.CodigoBarrasEgreso.Name = "CodigoBarrasEgreso";
            this.CodigoBarrasEgreso.Size = new System.Drawing.Size(267, 20);
            this.CodigoBarrasEgreso.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Info;
            this.btnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnVolver.Location = new System.Drawing.Point(190, 275);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(158, 47);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver a la Pantalla Principal";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(206, 194);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 47);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ComboDeposito
            // 
            this.ComboDeposito.FormattingEnabled = true;
            this.ComboDeposito.Location = new System.Drawing.Point(46, 140);
            this.ComboDeposito.Name = "ComboDeposito";
            this.ComboDeposito.Size = new System.Drawing.Size(267, 21);
            this.ComboDeposito.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label7.Location = new System.Drawing.Point(46, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seleccione el deposito";
            // 
            // EgresoMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 334);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboDeposito);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.CodigoBarrasEgreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EgresoMercaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EgresoMercaderia";
            this.VisibleChanged += new System.EventHandler(this.EgresoMercaderia_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoBarrasEgreso;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox ComboDeposito;
        private System.Windows.Forms.Label label7;
    }
}