namespace GSBCR.UI
{
    partial class FrmConnexion
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.gsb_visite_groupe1DataSet = new GSBCR.UI.gsb_visite_groupe1DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(336, 335);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Valider";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se connecter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identifiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(160, 154);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(195, 20);
            this.tbxId.TabIndex = 4;
            this.tbxId.Text = "a131";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(160, 215);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(195, 20);
            this.tbxMdp.TabIndex = 5;
            this.tbxMdp.Text = "30BFD069";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(53, 109);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(203, 20);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "! Informations incorrectes";
            this.lblError.Visible = false;
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.DataSource = this.gsb_visite_groupe1DataSet;
            this.bsVisiteur.Position = 0;
            // 
            // gsb_visite_groupe1DataSet
            // 
            this.gsb_visite_groupe1DataSet.DataSetName = "gsb_visite_groupe1DataSet";
            this.gsb_visite_groupe1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_visite_groupe1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private gsb_visite_groupe1DataSet gsb_visite_groupe1DataSet;
    }
}