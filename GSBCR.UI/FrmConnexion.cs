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
    public partial class FrmConnexion : Form
    {
        private VISITEUR leVisiteur;
        private const bool V = true;
        string matricule;
        string mdp;

        public FrmConnexion()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            matricule = tbxId.Text;
            mdp = tbxMdp.Text;
            // Visiteur
            leVisiteur = VisiteurManager.ChargerVisiteur(matricule, mdp);
            if(leVisiteur == null)
            {
                lblError.Visible = V;
            }
            else
            {
                FrmMenuVisiteur v = new FrmMenuVisiteur(matricule, mdp);
                v.ShowDialog();
                this.Close();
            }
            
        }
    }
}
