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
            if (matricule != "" && mdp != "")
            {
                leVisiteur = VisiteurManager.ChargerVisiteur(matricule, mdp);
                if (leVisiteur == null)
                {
                    lblError.Visible = V;
                }
                else
                {
                    lblError.Visible = V;
                    lblError.Text = "Connexion réussie";
                    FrmMenuVisiteur v = new FrmMenuVisiteur(matricule, mdp);
                    v.ShowDialog();

                }
            }
            else
            {
                lblError.Visible = V;
                lblError.Text = "Il y a des champs vide!";
            }
        }

        private void btnVisiteur_Click(object sender, EventArgs e)
        {
            tbxId.Text = "a131";
            tbxMdp.Text = "30BFD069";
        }

        private void btnDelegue_Click(object sender, EventArgs e)
        {
            tbxId.Text = "k53";
            tbxMdp.Text = "D416E9B0";
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            tbxId.Text = "j45";
            tbxMdp.Text = "B8703965";
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            tbxId.Text = "r24";
            tbxMdp.Text = "5BD22344";
        }
    }
}
