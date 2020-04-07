namespace GSBCR.UI
{
    partial class FrmRapportValide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapportValide));
            this.bsRapportValide = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgRapportValide = new System.Windows.Forms.DataGridView();
            this.rAPMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPCONFIANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPBILANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMotifVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lePraticienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxVis = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportValide)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRapportValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsRapportValide
            // 
            this.bsRapportValide.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.White;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(920, 25);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(102, 28);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgRapportValide);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.txtboxVis);
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vos rapports validés";
            // 
            // dvgRapportValide
            // 
            this.dvgRapportValide.AllowUserToAddRows = false;
            this.dvgRapportValide.AllowUserToDeleteRows = false;
            this.dvgRapportValide.AutoGenerateColumns = false;
            this.dvgRapportValide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgRapportValide.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgRapportValide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRapportValide.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPMATRICULEDataGridViewTextBoxColumn,
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATEDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPCONFIANCEDataGridViewTextBoxColumn,
            this.rAPBILANDataGridViewTextBoxColumn,
            this.rAPMOTIFDataGridViewTextBoxColumn,
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn,
            this.leMedicament1DataGridViewTextBoxColumn,
            this.leMedicament2DataGridViewTextBoxColumn,
            this.leMotifVisiteDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lePraticienDataGridViewTextBoxColumn,
            this.leVisiteurDataGridViewTextBoxColumn});
            this.dvgRapportValide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dvgRapportValide.DataSource = this.bsRapportValide;
            this.dvgRapportValide.Location = new System.Drawing.Point(6, 98);
            this.dvgRapportValide.Name = "dvgRapportValide";
            this.dvgRapportValide.ReadOnly = true;
            this.dvgRapportValide.RowHeadersWidth = 62;
            this.dvgRapportValide.Size = new System.Drawing.Size(1016, 411);
            this.dvgRapportValide.TabIndex = 2;
            this.dvgRapportValide.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRapportValide_CellDoubleClick);
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            this.rAPMATRICULEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Visible = false;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "n°";
            this.rAPNUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            this.rAPNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPNUMDataGridViewTextBoxColumn.Width = 50;
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "n° Praticien";
            this.rAPPRANUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            this.rAPPRANUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPPRANUMDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.rAPDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            this.rAPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPDATEDataGridViewTextBoxColumn.Visible = false;
            this.rAPDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "Date visite";
            this.rAPDATVISITDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            this.rAPDATVISITDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPDATVISITDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.rAPETATDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            this.rAPETATDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPETATDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Visible = false;
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            this.rAPBILANDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPBILANDataGridViewTextBoxColumn.Visible = false;
            this.rAPBILANDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.rAPMOTIFDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            this.rAPMOTIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMOTIFDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "Autre motif";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Visible = false;
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "Medicament 1";
            this.rAPMED1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            this.rAPMED1DataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMED1DataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "Medicament 2";
            this.rAPMED2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            this.rAPMED2DataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMED2DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMedicament1DataGridViewTextBoxColumn
            // 
            this.leMedicament1DataGridViewTextBoxColumn.DataPropertyName = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.HeaderText = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMedicament1DataGridViewTextBoxColumn.Name = "leMedicament1DataGridViewTextBoxColumn";
            this.leMedicament1DataGridViewTextBoxColumn.ReadOnly = true;
            this.leMedicament1DataGridViewTextBoxColumn.Visible = false;
            this.leMedicament1DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMedicament2DataGridViewTextBoxColumn
            // 
            this.leMedicament2DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.HeaderText = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMedicament2DataGridViewTextBoxColumn.Name = "leMedicament2DataGridViewTextBoxColumn";
            this.leMedicament2DataGridViewTextBoxColumn.ReadOnly = true;
            this.leMedicament2DataGridViewTextBoxColumn.Visible = false;
            this.leMedicament2DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMotifVisiteDataGridViewTextBoxColumn
            // 
            this.leMotifVisiteDataGridViewTextBoxColumn.DataPropertyName = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.HeaderText = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMotifVisiteDataGridViewTextBoxColumn.Name = "leMotifVisiteDataGridViewTextBoxColumn";
            this.leMotifVisiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.leMotifVisiteDataGridViewTextBoxColumn.Visible = false;
            this.leMotifVisiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.ReadOnly = true;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Visible = false;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Width = 150;
            // 
            // lePraticienDataGridViewTextBoxColumn
            // 
            this.lePraticienDataGridViewTextBoxColumn.DataPropertyName = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.HeaderText = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lePraticienDataGridViewTextBoxColumn.Name = "lePraticienDataGridViewTextBoxColumn";
            this.lePraticienDataGridViewTextBoxColumn.ReadOnly = true;
            this.lePraticienDataGridViewTextBoxColumn.Visible = false;
            this.lePraticienDataGridViewTextBoxColumn.Width = 150;
            // 
            // leVisiteurDataGridViewTextBoxColumn
            // 
            this.leVisiteurDataGridViewTextBoxColumn.DataPropertyName = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.HeaderText = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leVisiteurDataGridViewTextBoxColumn.Name = "leVisiteurDataGridViewTextBoxColumn";
            this.leVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            this.leVisiteurDataGridViewTextBoxColumn.Visible = false;
            this.leVisiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // txtboxVis
            // 
            this.txtboxVis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxVis.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtboxVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxVis.Location = new System.Drawing.Point(46, 41);
            this.txtboxVis.Multiline = true;
            this.txtboxVis.Name = "txtboxVis";
            this.txtboxVis.ReadOnly = true;
            this.txtboxVis.Size = new System.Drawing.Size(155, 25);
            this.txtboxVis.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 35);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 39);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmRapportValide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1052, 539);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRapportValide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GSBCR";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportValide)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRapportValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsRapportValide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxVis;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dvgRapportValide;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMotifVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lePraticienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leVisiteurDataGridViewTextBoxColumn;
    }
}