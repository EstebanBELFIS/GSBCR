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
    public partial class FrmChangerMdp : Form
    {
        private VISITEUR leVisiteur;
        public FrmChangerMdp(VISITEUR v)
        {
            InitializeComponent();
            leVisiteur = v;
            label1.Visible = true;
            label1.Text = leVisiteur.VIS_NOM + ' ' + leVisiteur.Vis_PRENOM;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string ancien = tbxAncienMdp.Text;
            string nouveau = tbxNouveau.Text;
            string confirm = tbxConfirm.Text;
            // Visiteur
            VISITEUR verif = VisiteurManager.ChargerVisiteur(leVisiteur.VIS_MATRICULE, ancien);
            if (leVisiteur == null)
            {
                lblError.Text = "Ancien mot de passe incorrect";
                lblError.Visible = true;
            }
            else
            {
                if(nouveau == confirm && nouveau != ""){
                    leVisiteur.vis_mdp = nouveau;
                    VisiteurManager.MajMDPVisiteur(leVisiteur);
                    lblError.Text = "Votre mot de passe a bien été modifié";
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Text = "Données incorrectes pour le nouveau mot de passe";
                    lblError.Visible = true;
                }
                
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
