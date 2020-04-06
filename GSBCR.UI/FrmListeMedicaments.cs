using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;
using GSBCR.UC;

namespace GSBCR.UI
{
    public partial class FrmListeMedicaments : Form
    {
        public FrmListeMedicaments()
        {
            InitializeComponent();
            // Medicament
            bsMedicaments.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedoc.DataSource = bsMedicaments;
            cbxMedoc.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void ucMedicament1_Load(object sender, EventArgs e)
        {

        }

        private void FrmListeMedicaments_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedoc.SelectedIndex = -1;
        }

        private void cbxMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
