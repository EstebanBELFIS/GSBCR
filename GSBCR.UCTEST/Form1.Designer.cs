namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMedoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPratictien = new System.Windows.Forms.ComboBox();
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.ucPratictien1 = new GSBCR.UC.UcPratictien();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMedoc
            // 
            this.cbxMedoc.FormattingEnabled = true;
            this.cbxMedoc.Location = new System.Drawing.Point(15, 40);
            this.cbxMedoc.Name = "cbxMedoc";
            this.cbxMedoc.Size = new System.Drawing.Size(146, 21);
            this.cbxMedoc.TabIndex = 2;
            this.cbxMedoc.SelectedIndexChanged += new System.EventHandler(this.cbxMedoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choix d\'un médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix d\'un pratictien";
            // 
            // cbxPratictien
            // 
            this.cbxPratictien.FormattingEnabled = true;
            this.cbxPratictien.Location = new System.Drawing.Point(458, 40);
            this.cbxPratictien.Name = "cbxPratictien";
            this.cbxPratictien.Size = new System.Drawing.Size(174, 21);
            this.cbxPratictien.TabIndex = 5;
            this.cbxPratictien.SelectedIndexChanged += new System.EventHandler(this.cbxPratictien_SelectedIndexChanged);
            // 
            // ucPratictien1
            // 
            this.ucPratictien1.Location = new System.Drawing.Point(337, 72);
            this.ucPratictien1.Name = "ucPratictien1";
            this.ucPratictien1.pRATICIEN = null;
            this.ucPratictien1.Size = new System.Drawing.Size(519, 348);
            this.ucPratictien1.TabIndex = 6;
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(-28, 61);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(393, 359);
            this.ucMedicament1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 421);
            this.Controls.Add(this.ucPratictien1);
            this.Controls.Add(this.cbxPratictien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMedoc);
            this.Controls.Add(this.ucMedicament1);
            this.Name = "Form1";
            this.Text = "Formulaire GSBCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMedoc;
        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.ComboBox cbxMedoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPratictien;
        private UC.UcPratictien ucPratictien1;
        private System.Windows.Forms.BindingSource bsPracticien;
    }
}

