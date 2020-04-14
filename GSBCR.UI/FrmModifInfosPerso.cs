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
    public partial class FrmModifInfosPerso : Form
    {
        private VISITEUR leVisiteur;
        public FrmModifInfosPerso(VISITEUR v)
        {
            InitializeComponent();
            leVisiteur = v;
            label1.Visible = true;
            label1.Text = leVisiteur.VIS_NOM + ' ' + leVisiteur.Vis_PRENOM;
            tbxAdresse.Text = leVisiteur.VIS_ADRESSE;
            tbxCP.Text = leVisiteur.VIS_CP;
            tbxVille.Text = leVisiteur.VIS_VILLE;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string Adresse = tbxAdresse.Text;
            string CP = tbxCP.Text;
            string Ville = tbxVille.Text;
            if (Adresse != "" && CP != "" && Ville != "")
            {
                if (Ville.All(char.IsLetter) && CP.All(char.IsDigit) && CP.Length == 5)
                {
                    leVisiteur.VIS_ADRESSE = Adresse;
                    leVisiteur.VIS_CP = CP;
                    leVisiteur.VIS_VILLE = Ville;
                    VisiteurManager.MajInfosVisiteur(leVisiteur);
                    lblError.Text = "Vos informations ont bien été modifiés";
                    lblError.Visible = true;
                }
                else
                {
                    MessageBox.Show("Les valeurs renseignées ne sont pas valides", "Données incorrectes pour l'adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs sont vides", "Données incorrectes pour l'adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
