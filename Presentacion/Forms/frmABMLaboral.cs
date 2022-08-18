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
    }
}
