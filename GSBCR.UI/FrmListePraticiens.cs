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
    public partial class FrmListePraticiens : Form
    {
        public FrmListePraticiens()
        {
            InitializeComponent();
            // Pratictien
            bsPraticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPratictien.DataSource = bsPraticien;
            cbxPratictien.DisplayMember = "PRA_NOM";
        }

        private void FrmListePraticiens_Load(object sender, EventArgs e)
        {
            ucPratictien1.Visible = false;
            cbxPratictien.SelectedIndex = -1;
        }

        private void cbxPratictien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPratictien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPratictien.SelectedItem;
                ucPratictien1.pRATICIEN = p;
                ucPratictien1.Visible = true;
            }
        }

        private void bsPraticien_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
