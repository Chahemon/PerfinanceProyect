namespace Dashboard
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
            this.botonCircular1 = new Dashboard.BotonCircular();
            this.SuspendLayout();
            // 
            // botonCircular1
            // 
            this.botonCircular1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.botonCircular1.FlatAppearance.BorderSize = 0;
            this.botonCircular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCircular1.Image = global::Dashboard.Properties.Resources.add_plus_create_new_icon_64px;
            this.botonCircular1.Location = new System.Drawing.Point(672, 438);
            this.botonCircular1.Name = "botonCircular1";
            this.botonCircular1.Size = new System.Drawing.Size(63, 63);
            this.botonCircular1.TabIndex = 0;
            this.botonCircular1.UseVisualStyleBackColor = false;
            this.botonCircular1.Click += new System.EventHandler(this.botonCircular1_Click);
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 513);
            this.Controls.Add(this.botonCircular1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresos";
            this.Text = "Ingresos";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonCircular botonCircular1;
    }
}