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
        private VISITEUR leVisiteur;
        private PRATICIEN lePraticien;
        public FrmListePraticiens(VISITEUR v)
        {
            InitializeComponent();
            // Pratictien
            leVisiteur = v;
            bsPraticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPratictien.DataSource = bsPraticien;
            cbxPratictien.DisplayMember = "PRA_NOM";
            ucPratictien1.Visible = false;
            cbxPratictien.SelectedIndex = -1;
            btnRapport.Visible = false;

        }

        public FrmListePraticiens(int index)
        {
            InitializeComponent();
            // Pratictien
            bsPraticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPratictien.DataSource = bsPraticien;
            cbxPratictien.DisplayMember = "PRA_NOM";
            cbxPratictien.SelectedIndex = index;
            if (cbxPratictien.SelectedIndex != -1 )
            {
                PRATICIEN p = (PRATICIEN)cbxPratictien.SelectedItem;
                ucPratictien1.pRATICIEN = p;
                ucPratictien1.Visible = true;
            }
            else
            {
                ucPratictien1.Visible = false;
                cbxPratictien.SelectedIndex = -1;
            }
           
        }

        private void cbxPratictien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPratictien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPratictien.SelectedItem;
                lePraticien = p;
                ucPratictien1.pRATICIEN = p;
                ucPratictien1.Visible = true;
                List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurPraticien(leVisiteur.VIS_MATRICULE, lePraticien.PRA_NUM);
                if(lr!= null && lr.Count > 0)
                {
                    btnRapport.Visible = true;

                }
                else{
                    btnRapport.Visible = false;
                }
            }
        }

        private void bsPraticien_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            PRATICIEN p = (PRATICIEN)cbxPratictien.SelectedItem;
            lePraticien = p;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurPraticien(leVisiteur.VIS_MATRICULE, lePraticien.PRA_NUM);
            
            FrmRapportEnCours f = new FrmRapportEnCours(leVisiteur, lr);
            f.ShowDialog();
        }
    }
}
