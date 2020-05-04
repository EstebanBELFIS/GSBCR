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
    public partial class FrmRapportConsulte : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION vaff;
        public FrmRapportConsulte(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapportEnCours.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapportEnCours;
        }

        public FrmRapportConsulte(VAFFECTATION v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            vaff = v;
            label2.Text = vaff.VIS_NOM;
            label3.Text = vaff.Vis_PRENOM;
            bsRapportEnCours.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapportEnCours;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportEnCours.Current;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
            //On relance la liaison de données pour actualiser l'état des rapports
            if (r.RAP_ETAT == "2")
            {
                //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                bsRapportEnCours.RemoveCurrent();
            }
            else
            {
                bsRapportEnCours.ResetCurrentItem();
            }
        }
    }
}
