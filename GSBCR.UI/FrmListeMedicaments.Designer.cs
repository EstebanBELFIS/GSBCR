namespace GSBCR.UI
{
    partial class FrmListeMedicaments
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedoc = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.bsMedicaments = new System.Windows.Forms.BindingSource(this.components);
            this.gsb_visite_groupe1DataSet = new GSBCR.UI.gsb_visite_groupe1DataSet();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choix d\'un médicament";
            // 
            // cbxMedoc
            // 
            this.cbxMedoc.FormattingEnabled = true;
            this.cbxMedoc.Location = new System.Drawing.Point(61, 79);
            this.cbxMedoc.Name = "cbxMedoc";
            this.cbxMedoc.Size = new System.Drawing.Size(146, 21);
            this.cbxMedoc.TabIndex = 5;
            this.cbxMedoc.SelectedIndexChanged += new System.EventHandler(this.cbxMedoc_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(298, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bsMedicaments
            // 
            this.bsMedicaments.DataSource = this.gsb_visite_groupe1DataSet;
            this.bsMedicaments.Position = 0;
            // 
            // gsb_visite_groupe1DataSet
            // 
            this.gsb_visite_groupe1DataSet.DataSetName = "gsb_visite_groupe1DataSet";
            this.gsb_visite_groupe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(12, 106);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(425, 435);
            this.ucMedicament1.TabIndex = 0;
            this.ucMedicament1.Load += new System.EventHandler(this.ucMedicament1_Load);
            // 
            // FrmListeMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 544);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxMedoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMedicament1);
            this.Name = "FrmListeMedicaments";
            this.Text = "FrmListeMedicaments";
            this.Load += new System.EventHandler(this.FrmListeMedicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMedoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bsMedicaments;
        private gsb_visite_groupe1DataSet gsb_visite_groupe1DataSet;
    }
}