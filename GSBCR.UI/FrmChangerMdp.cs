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

        }
    }
}
