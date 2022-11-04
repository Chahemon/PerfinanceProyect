namespace Dashboard
{
    partial class AgregarEgreso
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
            this.button1 = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCuenta = new System.Windows.Forms.ComboBox();
            this.comboBoxCuentaEgreso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Location = new System.Drawing.Point(238, 245);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.botonCerrar.TabIndex = 1;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(31, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCantidad.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxCantidad.Location = new System.Drawing.Point(33, 119);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 7;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(33, 167);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescripcion.TabIndex = 9;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBoxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoria.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Comida",
            "Salud",
            "Educacion",
            "Transporte"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(33, 69);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategoria.TabIndex = 10;
            this.comboBoxCategoria.Text = "-- SELECCIONE UNA --";
            this.comboBoxCategoria.Enter += new System.EventHandler(this.categoriaPlaceholder_mouseEnter);
            this.comboBoxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategoria_KeyPress);
            this.comboBoxCategoria.Leave += new System.EventHandler(this.categoriaPlaceholder_mouseLeave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dateTimePicker.Location = new System.Drawing.Point(33, 212);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // comboBoxCuenta
            // 
            this.comboBoxCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBoxCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCuenta.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxCuenta.FormattingEnabled = true;
            this.comboBoxCuenta.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito",
            "Otros"});
            this.comboBoxCuenta.Location = new System.Drawing.Point(34, 24);
            this.comboBoxCuenta.Name = "comboBoxCuenta";
            this.comboBoxCuenta.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCuenta.TabIndex = 12;
            this.comboBoxCuenta.Text = "-- SELECCIONE UNA --";
            this.comboBoxCuenta.Enter += new System.EventHandler(this.cuentaPlaceholder_mouseEnter);
            this.comboBoxCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCuenta_KeyPress);
            this.comboBoxCuenta.Leave += new System.EventHandler(this.cuentaPlaceholder_mouseLeave);
            // 
            // comboBoxCuentaEgreso
            // 
            this.comboBoxCuentaEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBoxCuentaEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCuentaEgreso.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxCuentaEgreso.FormattingEnabled = true;
            this.comboBoxCuentaEgreso.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito",
            "Otros"});
            this.comboBoxCuentaEgreso.Location = new System.Drawing.Point(33, 23);
            this.comboBoxCuentaEgreso.Name = "comboBoxCuentaEgreso";
            this.comboBoxCuentaEgreso.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCuentaEgreso.TabIndex = 12;
            this.comboBoxCuentaEgreso.Text = "-- SELECCIONE UNA --";
            // 
            // AgregarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.comboBoxCuentaEgreso);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEgreso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arrastrarFormEgreso_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxCuenta;
        private System.Windows.Forms.ComboBox comboBoxCuentaEgreso;
    }
}