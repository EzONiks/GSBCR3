namespace GSBCR.UI
{
    partial class FrmRapportUnPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapportUnPraticien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRapportUnPraticien = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRapportUnPraticien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportUnPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportUnPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les rapports du praticien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dgvRapportUnPraticien
            // 
            this.dgvRapportUnPraticien.AutoGenerateColumns = false;
            this.dgvRapportUnPraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapportUnPraticien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvRapportUnPraticien.DataSource = this.bsRapportUnPraticien;
            this.dgvRapportUnPraticien.Location = new System.Drawing.Point(21, 69);
            this.dgvRapportUnPraticien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRapportUnPraticien.Name = "dgvRapportUnPraticien";
            this.dgvRapportUnPraticien.RowHeadersWidth = 62;
            this.dgvRapportUnPraticien.RowTemplate.Height = 28;
            this.dgvRapportUnPraticien.Size = new System.Drawing.Size(664, 201);
            this.dgvRapportUnPraticien.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.btnQuit.Location = new System.Drawing.Point(581, 18);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(73, 27);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(488, 19);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(82, 25);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RAP_NUM";
            this.dataGridViewTextBoxColumn1.HeaderText = "RAP_NUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RAP_DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "RAP_DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RAP_DATVISIT";
            this.dataGridViewTextBoxColumn3.HeaderText = "RAP_DATVISIT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RAP_ETAT";
            this.dataGridViewTextBoxColumn4.HeaderText = "RAP_ETAT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RAP_CONFIANCE";
            this.dataGridViewTextBoxColumn5.HeaderText = "RAP_CONFIANCE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RAP_BILAN";
            this.dataGridViewTextBoxColumn6.HeaderText = "RAP_BILAN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RAP_MOTIF";
            this.dataGridViewTextBoxColumn7.HeaderText = "RAP_MOTIF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RAP_MOTIFAUTRE";
            this.dataGridViewTextBoxColumn8.HeaderText = "RAP_MOTIFAUTRE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RAP_MED1";
            this.dataGridViewTextBoxColumn9.HeaderText = "RAP_MED1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RAP_MED2";
            this.dataGridViewTextBoxColumn10.HeaderText = "RAP_MED2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // bsRapportUnPraticien
            // 
            this.bsRapportUnPraticien.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // FrmRapportUnPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 279);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dgvRapportUnPraticien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRapportUnPraticien";
            this.Text = "GSBCR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportUnPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportUnPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRapportUnPraticien;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.BindingSource bsRapportUnPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}