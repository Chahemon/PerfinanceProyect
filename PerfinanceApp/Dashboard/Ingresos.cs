using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    
    public partial class Ingresos : Form
    {

        private string usuarioId;
        private List<Ingreso> lstIngresos;

        public Ingresos( string usuarioId, List <Ingreso> lstIngreso)
        {
            this.usuarioId = usuarioId;
            this.lstIngresos = lstIngreso;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarIngreso ventana = new AgregarIngreso( usuarioId );
            ventana.ShowDialog();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            foreach (var list in lstIngresos)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView.Rows[0].Clone();
                row.Cells[0].Value = list.Categoria;     // Categoria
                row.Cells[1].Value = list.CreatedAt;      // Fecha
                row.Cells[2].Value = list.Valor;        // Cantidad
                dataGridView.Rows.Add(row);
            }
            
        }

        
    }
}
