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
            this.txtBoxCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 302);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonSalirIngresos
            // 
            this.botonSalirIngresos.Location = new System.Drawing.Point(301, 302);
            this.botonSalirIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonSalirIngresos.Name = "botonSalirIngresos";
            this.botonSalirIngresos.Size = new System.Drawing.Size(100, 28);
            this.botonSalirIngresos.TabIndex = 1;
            this.botonSalirIngresos.Text = "Cerrar";
            this.botonSalirIngresos.UseVisualStyleBackColor = true;
            this.botonSalirIngresos.Click += new System.EventHandler(this.botonSalirIngresos_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Sueldo",
            "Bonos",
            "Pensión",
            "Otro"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(45, 90);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(265, 24);
            this.comboBoxCategoria.TabIndex = 2;
            this.comboBoxCategoria.Text = "-- SELECCIONE UNA --";
            this.comboBoxCategoria.Enter += new System.EventHandler(this.categoriaPlaceholder_mouseEnter);
            this.comboBoxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategoria_KeyPress);
            this.comboBoxCategoria.Leave += new System.EventHandler(this.categoriaPlaceholder_mouseLeave);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCantidad.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxCantidad.Location = new System.Drawing.Point(42, 152);
            this.txtBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(133, 22);
            this.txtBoxCantidad.TabIndex = 3;
            this.txtBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // txtBoxCuenta
            // 
            this.txtBoxCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCuenta.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxCuenta.Location = new System.Drawing.Point(45, 30);
            this.txtBoxCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCuenta.Name = "txtBoxCuenta";
            this.txtBoxCuenta.Size = new System.Drawing.Size(133, 22);
            this.txtBoxCuenta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(42, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cuenta";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dateTimePicker.Location = new System.Drawing.Point(41, 262);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 15;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(41, 208);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(133, 22);
            this.txtBoxDescripcion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(38, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(38, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción";
            // 
            // AgregarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(463, 343);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.botonSalirIngresos);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private TextBox txtBoxCuenta;
        private Label label3;
        private DateTimePicker dateTimePicker;
        private TextBox txtBoxDescripcion;
        private Label label5;
        private Label label4;
    }
}