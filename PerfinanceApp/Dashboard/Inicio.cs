﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hector, dice jorge que eres un pendejo xd

namespace Dashboard
{
    public partial class Inicio : Form
    {
        private bool temaOscuro;

        public Inicio(bool temaOscuro)
        {
            this.temaOscuro = temaOscuro;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
