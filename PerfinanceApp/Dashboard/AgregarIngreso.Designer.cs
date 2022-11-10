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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarIngreso));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.botonSalirIngresos = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCuentaIngreso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(17, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonSalirIngresos
            // 
            this.botonSalirIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonSalirIngresos.FlatAppearance.BorderSize = 0;
            this.botonSalirIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalirIngresos.Location = new System.Drawing.Point(157, 265);
            this.botonSalirIngresos.Name = "botonSalirIngresos";
            this.botonSalirIngresos.Size = new System.Drawing.Size(113, 32);
            this.botonSalirIngresos.TabIndex = 1;
            this.botonSalirIngresos.Text = "CERRAR";
            this.botonSalirIngresos.UseVisualStyleBackColor = false;
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
            this.comboBoxCategoria.Location = new System.Drawing.Point(16, 69);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
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
            this.txtBoxCantidad.Location = new System.Drawing.Point(17, 118);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 3;
            this.txtBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cuenta";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dateTimePicker.Location = new System.Drawing.Point(16, 212);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxDescripcion.Location = new System.Drawing.Point(17, 165);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescripcion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción";
            // 
            // comboBoxCuentaIngreso
            // 
            this.comboBoxCuentaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboBoxCuentaIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCuentaIngreso.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxCuentaIngreso.FormattingEnabled = true;
            this.comboBoxCuentaIngreso.Items.AddRange(new object[] {
            "Efectivo",
            "Debito",
            "Credito",
            "Otros"});
            this.comboBoxCuentaIngreso.Location = new System.Drawing.Point(16, 24);
            this.comboBoxCuentaIngreso.Name = "comboBoxCuentaIngreso";
            this.comboBoxCuentaIngreso.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCuentaIngreso.TabIndex = 16;
            this.comboBoxCuentaIngreso.Text = "-- SELECCIONE UNA --";
            this.comboBoxCuentaIngreso.Enter += new System.EventHandler(this.cuentaPlaceholder_mouseEnter);
            this.comboBoxCuentaIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCuenta_KeyPress);
            this.comboBoxCuentaIngreso.Leave += new System.EventHandler(this.cuentaPlaceholder_mouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Todos los Campos son Obligatorios";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.comboBoxCuentaIngreso);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.botonSalirIngresos);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.comboBoxCategoria);
            this.panel1.Controls.Add(this.txtBoxDescripcion);
            this.panel1.Controls.Add(this.txtBoxCantidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 311);
            this.panel1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(267, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Agregar Ingreso";
            // 
            // AgregarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(292, 340);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarIngreso";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarIngreso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arrastrarFormIngreso_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label label3;
        private DateTimePicker dateTimePicker;
        private TextBox txtBoxDescripcion;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxCuentaIngreso;
        private Label label6;
        private Panel panel1;
        private Button button2;
        private Label label7;
    }
}