
namespace Dashboard
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControlador = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panNav);
            this.panel1.Controls.Add(this.btnOpciones);
            this.panel1.Controls.Add(this.btnCalendario);
            this.panel1.Controls.Add(this.btnAnalisis);
            this.panel1.Controls.Add(this.btnEgresos);
            this.panel1.Controls.Add(this.btnIngresos);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.Coral;
            this.panNav.Location = new System.Drawing.Point(0, 193);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(3, 100);
            this.panNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "User data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(220, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inicio";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(607, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Buscar";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextSelected);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(922, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpciones.Image = global::Dashboard.Properties.Resources.opciones;
            this.btnOpciones.Location = new System.Drawing.Point(0, 535);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(186, 42);
            this.btnOpciones.TabIndex = 1;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            this.btnOpciones.Leave += new System.EventHandler(this.btnOpciones_Leave);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalendario.Image = global::Dashboard.Properties.Resources.calendario;
            this.btnCalendario.Location = new System.Drawing.Point(0, 312);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(186, 42);
            this.btnCalendario.TabIndex = 1;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendario.Leave += new System.EventHandler(this.btnCalendario_Leave);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnalisis.Image = global::Dashboard.Properties.Resources.analisis__1_;
            this.btnAnalisis.Location = new System.Drawing.Point(0, 270);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(186, 42);
            this.btnAnalisis.TabIndex = 1;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            this.btnAnalisis.Leave += new System.EventHandler(this.btnAnalisis_Leave);
            // 
            // btnEgresos
            // 
            this.btnEgresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEgresos.FlatAppearance.BorderSize = 0;
            this.btnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEgresos.Image = global::Dashboard.Properties.Resources.ingresos_y_egresos__1_;
            this.btnEgresos.Location = new System.Drawing.Point(0, 228);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Size = new System.Drawing.Size(186, 42);
            this.btnEgresos.TabIndex = 1;
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEgresos.UseVisualStyleBackColor = true;
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            this.btnEgresos.Leave += new System.EventHandler(this.btnEgresos_Leave);
            // 
            // btnIngresos
            // 
            this.btnIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIngresos.Image = global::Dashboard.Properties.Resources.ingresos;
            this.btnIngresos.Location = new System.Drawing.Point(0, 186);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(186, 42);
            this.btnIngresos.TabIndex = 1;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            this.btnIngresos.Leave += new System.EventHandler(this.btnIngresos_Leave);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInicio.Image = global::Dashboard.Properties.Resources.home;
            this.btnInicio.Location = new System.Drawing.Point(0, 144);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(186, 42);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.Leave += new System.EventHandler(this.btnInicio_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.icone_utilisateur_orange;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelControlador
            // 
            this.panelControlador.Location = new System.Drawing.Point(192, 52);
            this.panelControlador.Name = "panelControlador";
            this.panelControlador.Size = new System.Drawing.Size(747, 513);
            this.panelControlador.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelControlador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnEgresos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelControlador;
    }
}

