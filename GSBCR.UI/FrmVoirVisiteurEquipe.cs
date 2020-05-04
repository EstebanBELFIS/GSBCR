using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmVoirVisiteurEquipe : Form
    {
        private VISITEUR leVisiteur;
        public FrmVoirVisiteurEquipe(VISITEUR v, List<VISITEUR> lv, VAFFECTATION p)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM + " " + leVisiteur.Vis_PRENOM;
            label3.Text = p.REG_CODE;
            List <VAFFECTATION> lvaff = new List<VAFFECTATION>();
            foreach(VISITEUR vis in lv)
            {
                VAFFECTATION vaff = VisiteurManager.ChargerAffectationVisiteur(vis.VIS_MATRICULE);
                lvaff.Add(vaff);
            }
            bsVisiteurEquipe.DataSource = lvaff;
            dgvVisiteurEquipe.DataSource = bsVisiteurEquipe;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVisiteurEquipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VAFFECTATION v = (VAFFECTATION)bsVisiteurEquipe.Current;
            List<RAPPORT_VISITE> r = DelegueManager.ChargerRapportVisiteurLus(v.VIS_MATRICULE);
            FrmRapportConsulte f = new FrmRapportConsulte(v, r);
            f.ShowDialog();
            ////On relance la liaison de données pour actualiser l'état des rapports
        }
    }
}
