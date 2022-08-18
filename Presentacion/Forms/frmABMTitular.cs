using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class frmABMTitular : Form
    {
        private Pre_TitularModel titular = new Pre_TitularModel();
        public frmABMTitular()
        {
            InitializeComponent();
            // panel1.Enabled = false; 
        }

        private void ListarTitular()
        {
            try
            {
                dgvTitular.DataSource = titular.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmABMTitular_Load(object sender, EventArgs e)
        {
            ListarTitular();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTitular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTitular.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                //titular.Pre_id = Convert.ToInt32(dgvTitular.CurrentRow.Cells[0].Value);
                textNroFicha.Text = dgvTitular.CurrentRow.Cells[0].Value.ToString();
                textFechaInscrip.Value = Convert.ToDateTime(dgvTitular.CurrentRow.Cells[1].Value);
                textNombre.Text = dgvTitular.CurrentRow.Cells[2].Value.ToString();
                textTypeDoc.Text = dgvTitular.CurrentRow.Cells[3].Value.ToString();
                textNroDoc.Text = dgvTitular.CurrentRow.Cells[4].Value.ToString();
                textCuil.Text = dgvTitular.CurrentRow.Cells[5].Value.ToString(); 
                textNacionalidad.Text = dgvTitular.CurrentRow.Cells[6].Value.ToString(); 
                textGenero.Text = dgvTitular.CurrentRow.Cells[7].Value.ToString();
                // textFechaNac.Value = Convert.ToDateTime(dgvTitular.CurrentRow.Cells[8].Value);
                textTelefono.Text = dgvTitular.CurrentRow.Cells[9].Value.ToString(); 
                textCorreoElectr.Text = dgvTitular.CurrentRow.Cells[10].Value.ToString();

            }
        }

        private void dgvTitular_CellClick(object sender, KeyEventArgs e)
        {

        }
    }
}
