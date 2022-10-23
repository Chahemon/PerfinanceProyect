using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Dashboard
{
    partial class AgregarIngreso
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.botonSalirIngresos = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonSalirIngresos
            // 
            this.botonSalirIngresos.Location = new System.Drawing.Point(172, 159);
            this.botonSalirIngresos.Name = "botonSalirIngresos";
            this.botonSalirIngresos.Size = new System.Drawing.Size(75, 23);
            this.botonSalirIngresos.TabIndex = 1;
            this.botonSalirIngresos.Text = "Cerrar";
            this.botonSalirIngresos.UseVisualStyleBackColor = true;
            this.botonSalirIngresos.Click += new System.EventHandler(this.botonSalirIngresos_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Sueldo",
            "Bonos",
            "Pensión",
            "Otro"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(47, 93);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategoria.TabIndex = 2;
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(47, 42);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 3;
            this.txtBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // AgregarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(305, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.botonSalirIngresos);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarIngreso";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarIngreso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arrastrarFormIngreso_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button botonSalirIngresos;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}