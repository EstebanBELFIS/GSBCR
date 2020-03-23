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
    public partial class UcMedicament : UserControl
    {
        private MEDICAMENT leMedicament;
        public MEDICAMENT LeMedicament
        {
            get { return leMedicament; }
            set
            {
                leMedicament = value;
                if(leMedicament!= null)
                {
                    ucMedicament_actualiser();
                }
            }
        }
        public UcMedicament()
        {
            InitializeComponent();
        }

        private void ucMedicament_actualiser()
        {
            txtDepot.Text = leMedicament.MED_DEPOTLEGAL;
            txtNom.Text = leMedicament.MED_NOMCOMMERCIAL;
            txtCodeFam.Text = leMedicament.FAM_CODE;
            txtNomFam.Text = leMedicament.LaFamille.FAM_LIBELLE;
            txtComposition.Text = leMedicament.MED_COMPOSITION;
            txtContreInd.Text = leMedicament.MED_CONTREINDIC;
            txtEffet.Text = leMedicament.MED_EFFETS;
            txtPrix.Text = leMedicament.MED_PRIXECHANTILLON.ToString();

        }
    }
}
