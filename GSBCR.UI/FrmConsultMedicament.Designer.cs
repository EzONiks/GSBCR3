﻿namespace GSBCR.UI
{
    partial class FrmConsultMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultMedicament));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gSB_visite_RAVAZDataSet = new GSBCR.UI.GSB_visite_RAVAZDataSet();
            this.mEDICAMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAMENTTableAdapter = new GSBCR.UI.GSB_visite_RAVAZDataSetTableAdapters.MEDICAMENTTableAdapter();
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDEFFETSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDCONTREINDICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_visite_RAVAZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les Médicaments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn,
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn,
            this.fAMCODEDataGridViewTextBoxColumn,
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn,
            this.mEDEFFETSDataGridViewTextBoxColumn,
            this.mEDCONTREINDICDataGridViewTextBoxColumn,
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEDICAMENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(558, 40);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(196, 43);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gSB_visite_RAVAZDataSet
            // 
            this.gSB_visite_RAVAZDataSet.DataSetName = "GSB_visite_RAVAZDataSet";
            this.gSB_visite_RAVAZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICAMENTBindingSource
            // 
            this.mEDICAMENTBindingSource.DataMember = "MEDICAMENT";
            this.mEDICAMENTBindingSource.DataSource = this.gSB_visite_RAVAZDataSet;
            // 
            // mEDICAMENTTableAdapter
            // 
            this.mEDICAMENTTableAdapter.ClearBeforeFill = true;
            // 
            // mEDDEPOTLEGALDataGridViewTextBoxColumn
            // 
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.DataPropertyName = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.HeaderText = "MED_DEPOTLEGAL";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.Name = "mEDDEPOTLEGALDataGridViewTextBoxColumn";
            this.mEDDEPOTLEGALDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEDNOMCOMMERCIALDataGridViewTextBoxColumn
            // 
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.DataPropertyName = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.HeaderText = "MED_NOMCOMMERCIAL";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.Name = "mEDNOMCOMMERCIALDataGridViewTextBoxColumn";
            this.mEDNOMCOMMERCIALDataGridViewTextBoxColumn.Width = 150;
            // 
            // fAMCODEDataGridViewTextBoxColumn
            // 
            this.fAMCODEDataGridViewTextBoxColumn.DataPropertyName = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn.HeaderText = "FAM_CODE";
            this.fAMCODEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fAMCODEDataGridViewTextBoxColumn.Name = "fAMCODEDataGridViewTextBoxColumn";
            this.fAMCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEDCOMPOSITIONDataGridViewTextBoxColumn
            // 
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.HeaderText = "MED_COMPOSITION";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.Name = "mEDCOMPOSITIONDataGridViewTextBoxColumn";
            this.mEDCOMPOSITIONDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEDEFFETSDataGridViewTextBoxColumn
            // 
            this.mEDEFFETSDataGridViewTextBoxColumn.DataPropertyName = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn.HeaderText = "MED_EFFETS";
            this.mEDEFFETSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDEFFETSDataGridViewTextBoxColumn.Name = "mEDEFFETSDataGridViewTextBoxColumn";
            this.mEDEFFETSDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEDCONTREINDICDataGridViewTextBoxColumn
            // 
            this.mEDCONTREINDICDataGridViewTextBoxColumn.DataPropertyName = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn.HeaderText = "MED_CONTREINDIC";
            this.mEDCONTREINDICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDCONTREINDICDataGridViewTextBoxColumn.Name = "mEDCONTREINDICDataGridViewTextBoxColumn";
            this.mEDCONTREINDICDataGridViewTextBoxColumn.Width = 150;
            // 
            // mEDPRIXECHANTILLONDataGridViewTextBoxColumn
            // 
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.DataPropertyName = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.HeaderText = "MED_PRIXECHANTILLON";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.Name = "mEDPRIXECHANTILLONDataGridViewTextBoxColumn";
            this.mEDPRIXECHANTILLONDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmConsultMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 480);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultMedicament";
            this.Text = "GSBCR";
            this.Load += new System.EventHandler(this.FrmConsultMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_visite_RAVAZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuit;
        private GSB_visite_RAVAZDataSet gSB_visite_RAVAZDataSet;
        private System.Windows.Forms.BindingSource mEDICAMENTBindingSource;
        private GSB_visite_RAVAZDataSetTableAdapters.MEDICAMENTTableAdapter mEDICAMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDDEPOTLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDNOMCOMMERCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCOMPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDEFFETSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDCONTREINDICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDPRIXECHANTILLONDataGridViewTextBoxColumn;
    }
}