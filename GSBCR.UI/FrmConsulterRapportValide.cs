using GSBCR.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmConsulterRapportValide : Form
    {
        private VISITEUR leVisiteur;
        public FrmConsulterRapportValide(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapportEnCours.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapportEnCours;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
