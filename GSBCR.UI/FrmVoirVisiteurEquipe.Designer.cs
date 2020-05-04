namespace GSBCR.UI
{
    partial class FrmVoirVisiteurEquipe
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
            this.dgvVisiteurEquipe = new System.Windows.Forms.DataGridView();
            this.vISMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vis_PRENOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIS_DATEEMBAUCHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JJMMAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVisiteurEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Les visiteurs de votre équipe";
            // 
            // dgvVisiteurEquipe
            // 
            this.dgvVisiteurEquipe.AllowUserToAddRows = false;
            this.dgvVisiteurEquipe.AllowUserToDeleteRows = false;
            this.dgvVisiteurEquipe.AutoGenerateColumns = false;
            this.dgvVisiteurEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurEquipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vISMATRICULEDataGridViewTextBoxColumn,
            this.VIS_NOM,
            this.Vis_PRENOM,
            this.VIS_DATEEMBAUCHE,
            this.JJMMAA});
            this.dgvVisiteurEquipe.DataSource = this.bsVisiteurEquipe;
            this.dgvVisiteurEquipe.Location = new System.Drawing.Point(1, 130);
            this.dgvVisiteurEquipe.Name = "dgvVisiteurEquipe";
            this.dgvVisiteurEquipe.Size = new System.Drawing.Size(853, 308);
            this.dgvVisiteurEquipe.TabIndex = 4;
            this.dgvVisiteurEquipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisiteurEquipe_CellDoubleClick);
            // 
            // vISMATRICULEDataGridViewTextBoxColumn
            // 
            this.vISMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "VIS_MATRICULE";
            this.vISMATRICULEDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.vISMATRICULEDataGridViewTextBoxColumn.Name = "vISMATRICULEDataGridViewTextBoxColumn";
            // 
            // VIS_NOM
            // 
            this.VIS_NOM.DataPropertyName = "VIS_NOM";
            this.VIS_NOM.HeaderText = "Nom";
            this.VIS_NOM.Name = "VIS_NOM";
            // 
            // Vis_PRENOM
            // 
            this.Vis_PRENOM.DataPropertyName = "Vis_PRENOM";
            this.Vis_PRENOM.HeaderText = "Prénom";
            this.Vis_PRENOM.Name = "Vis_PRENOM";
            // 
            // VIS_DATEEMBAUCHE
            // 
            this.VIS_DATEEMBAUCHE.DataPropertyName = "VIS_DATEEMBAUCHE";
            this.VIS_DATEEMBAUCHE.HeaderText = "Date d\'embauche";
            this.VIS_DATEEMBAUCHE.Name = "VIS_DATEEMBAUCHE";
            this.VIS_DATEEMBAUCHE.Width = 150;
            // 
            // JJMMAA
            // 
            this.JJMMAA.DataPropertyName = "JJMMAA";
            this.JJMMAA.HeaderText = "Date d\'affectation";
            this.JJMMAA.Name = "JJMMAA";
            this.JJMMAA.Width = 150;
            // 
            // bsVisiteurEquipe
            // 
            this.bsVisiteurEquipe.DataSource = typeof(GSBCR.modele.VAFFECTATION);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(719, 79);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // FrmVoirVisiteurEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.dgvVisiteurEquipe);
            this.Controls.Add(this.label1);
            this.Name = "FrmVoirVisiteurEquipe";
            this.Text = "FrmVoirVisiteurEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVisiteurEquipe;
        private System.Windows.Forms.BindingSource bsVisiteurEquipe;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vis_PRENOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIS_DATEEMBAUCHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JJMMAA;
    }
}