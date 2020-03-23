using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UcPratictien : UserControl
    {
        private PRATICIEN lePracticien; 

        public UcPratictien()
        {
            InitializeComponent();
        }

        public PRATICIEN pRATICIEN
        {
            get { return lePracticien; }
            set
            {
                lePracticien = value;
                if (lePracticien != null)
                {
                    ucPratictien_actualiser();
                }
            }
        }

        private void ucPratictien_actualiser()
        {
            txtNom.Text = lePracticien.PRA_NOM;
            txtPrenom.Text = lePracticien.PRA_PRENOM;
            txtAddr.Text = lePracticien.PRA_ADRESSE;
            txtCP.Text = lePracticien.PRA_CP;
            txtVille.Text = lePracticien.PRA_VILLE;
            txtCoef.Text = lePracticien.PRA_COEFNOTORIETE.ToString();
            txtFonction.Text = lePracticien.LeType.TYP_LIBELLE;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
