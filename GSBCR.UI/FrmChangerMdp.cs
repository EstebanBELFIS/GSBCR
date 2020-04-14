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
                MessageBox.Show("Ancien mot de passe incorrect", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (ancien != "" && nouveau != "" && confirm != "")
                {
                    if (ancien != nouveau)
                    {
                        if (nouveau == confirm)
                        {
                            if (nouveau.Length >= 8) {
                                if (ValidMDP(nouveau) == true)
                                {
                                    leVisiteur.vis_mdp = nouveau;
                                    VisiteurManager.MajMDPVisiteur(leVisiteur);
                                    lblError.Text = "Votre mot de passe a bien été modifié";
                                    lblError.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Le mot de passe n'est pas assez fort", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Le mot de passe est trop court, il doit contenir au minimum 8 characteres", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Les cases 'Nouveau' et 'Confirmer' n'ont pas les mêmes valeurs", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Votre nouveau mot de passe est identique à l'ancien", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Un ou plusieurs champs sont vides!", "Données incorrectes pour le nouveau mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidMDP(string mdp)
        {
            if (mdp.Any(char.IsUpper) && mdp.Any(char.IsLower) && mdp.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
