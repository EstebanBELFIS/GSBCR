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

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Medicament
            bsMedoc.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedoc.DataSource = bsMedoc;
            cbxMedoc.DisplayMember = "MED_NOMCOMMERCIAL";
            // Pratictien
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPratictien.DataSource = bsPracticien;
            cbxPratictien.DisplayMember = "PRA_NOM";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedoc.SelectedIndex = -1;
            ucPratictien1.Visible = false;
            cbxPratictien.SelectedIndex = -1;
        }

        private void cbxMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbxMedoc.SelectedIndex != -1 )
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }

        private void cbxPratictien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbxPratictien.SelectedIndex != -1 )
            {
                PRATICIEN p = (PRATICIEN)cbxPratictien.SelectedItem;
                ucPratictien1.pRATICIEN = p;
                ucPratictien1.Visible = true;
            }
        }
    }
}
