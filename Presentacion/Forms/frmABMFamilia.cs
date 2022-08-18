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
    public partial class frmABMFamilia : Form
    {
        private Pre_TitFamiliaModel titular = new Pre_TitFamiliaModel();
        public frmABMFamilia()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarFamilias()
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

        private void frmABMFamilia_Load(object sender, EventArgs e)
        {
            ListarFamilias();
        }
    }
}
