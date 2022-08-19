using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Modelos;
namespace Presentacion.Forms
{
    public partial class frmABMLaboral : Form
    {

        private Pre_TitLaboralModel titular = new Pre_TitLaboralModel();

        public frmABMLaboral()
        {
            InitializeComponent();
        }

        private void ListarLaboral()
        {
            try
            {
                dataGridView1.DataSource = titular.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmABMLaboral_Load(object sender, EventArgs e)
        {
            ListarLaboral();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = titular.FindById_Pre_Titular(Convert.ToInt32(textBox1.Text));
            // textFilterById.Text.StartsWith("");
            // textFilterById.Clear();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            exportarExcel(dataGridView1);
        }

        public void exportarExcel(DataGridView dataListado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Workbooks.Add(true);


            int indiceColumna = 0;
            foreach (DataGridViewColumn col in dataListado.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = col.Name;
            }
            int indiceFila = 0;
            foreach (DataGridViewRow row in dataListado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in dataListado.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            exportarExcel.Visible = true;

        }

    }
}
