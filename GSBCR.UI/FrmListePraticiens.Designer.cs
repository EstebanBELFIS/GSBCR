namespace GSBCR.UI
{
    partial class FrmListePraticiens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ucPratictien1 = new GSBCR.UC.UcPratictien();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPratictien = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.gsb_visite_groupe1DataSet = new GSBCR.UI.gsb_visite_groupe1DataSet();
            this.btnRapport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPratictien1
            // 
            this.ucPratictien1.Location = new System.Drawing.Point(12, 82);
            this.ucPratictien1.Name = "ucPratictien1";
            this.ucPratictien1.pRATICIEN = null;
            this.ucPratictien1.Size = new System.Drawing.Size(568, 356);
            this.ucPratictien1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choix d\'un pratictien";
            // 
            // cbxPratictien
            // 
            this.cbxPratictien.FormattingEnabled = true;
            this.cbxPratictien.Location = new System.Drawing.Point(45, 78);
            this.cbxPratictien.Name = "cbxPratictien";
            this.cbxPratictien.Size = new System.Drawing.Size(174, 21);
            this.cbxPratictien.TabIndex = 6;
            this.cbxPratictien.SelectedIndexChanged += new System.EventHandler(this.cbxPratictien_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(374, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bsPraticien
            // 
            this.bsPraticien.DataSource = this.gsb_visite_groupe1DataSet;
            this.bsPraticien.Position = 0;
            this.bsPraticien.CurrentChanged += new System.EventHandler(this.bsPraticien_CurrentChanged);
            // 
            // gsb_visite_groupe1DataSet
            // 
            this.gsb_visite_groupe1DataSet.DataSetName = "gsb_visite_groupe1DataSet";
            this.gsb_visite_groupe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(83, 415);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(262, 23);
            this.btnRapport.TabIndex = 9;
            this.btnRapport.Text = "Afficher mes rapports visites avec ce praticien";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Visible = false;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // FrmListePraticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxPratictien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucPratictien1);
            this.Name = "FrmListePraticiens";
            this.Text = "FrmListePraticiens";
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcPratictien ucPratictien1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPratictien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bsPraticien;
        private gsb_visite_groupe1DataSet gsb_visite_groupe1DataSet;
        private System.Windows.Forms.Button btnRapport;
    }
}