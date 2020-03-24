namespace GSBCR.UI
{
    partial class FrmPraticien
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
            this.dgvPraticien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rAPPORTVISITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRATICIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRANOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRATICIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPraticien
            // 
            this.dgvPraticien.AutoGenerateColumns = false;
            this.dgvPraticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRANUMDataGridViewTextBoxColumn,
            this.pRANOMDataGridViewTextBoxColumn,
            this.pRAPRENOMDataGridViewTextBoxColumn,
            this.pRAADRESSEDataGridViewTextBoxColumn,
            this.pRACPDataGridViewTextBoxColumn,
            this.pRAVILLEDataGridViewTextBoxColumn,
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn,
            this.tYPCODEDataGridViewTextBoxColumn});
            this.dgvPraticien.DataSource = this.pRATICIENBindingSource;
            this.dgvPraticien.Location = new System.Drawing.Point(12, 203);
            this.dgvPraticien.Name = "dgvPraticien";
            this.dgvPraticien.RowHeadersWidth = 62;
            this.dgvPraticien.RowTemplate.Height = 28;
            this.dgvPraticien.Size = new System.Drawing.Size(1264, 410);
            this.dgvPraticien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.Location = new System.Drawing.Point(456, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des praticiens";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(1084, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rAPPORTVISITEBindingSource
            // 
            this.rAPPORTVISITEBindingSource.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // pRATICIENBindingSource
            // 
            this.pRATICIENBindingSource.DataSource = typeof(GSBCR.modele.PRATICIEN);
            // 
            // pRANUMDataGridViewTextBoxColumn
            // 
            this.pRANUMDataGridViewTextBoxColumn.DataPropertyName = "PRA_NUM";
            this.pRANUMDataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.pRANUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRANUMDataGridViewTextBoxColumn.Name = "pRANUMDataGridViewTextBoxColumn";
            this.pRANUMDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRANOMDataGridViewTextBoxColumn
            // 
            this.pRANOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_NOM";
            this.pRANOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.pRANOMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRANOMDataGridViewTextBoxColumn.Name = "pRANOMDataGridViewTextBoxColumn";
            this.pRANOMDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRAPRENOMDataGridViewTextBoxColumn
            // 
            this.pRAPRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRA_PRENOM";
            this.pRAPRENOMDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.pRAPRENOMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRAPRENOMDataGridViewTextBoxColumn.Name = "pRAPRENOMDataGridViewTextBoxColumn";
            this.pRAPRENOMDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRAADRESSEDataGridViewTextBoxColumn
            // 
            this.pRAADRESSEDataGridViewTextBoxColumn.DataPropertyName = "PRA_ADRESSE";
            this.pRAADRESSEDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.pRAADRESSEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRAADRESSEDataGridViewTextBoxColumn.Name = "pRAADRESSEDataGridViewTextBoxColumn";
            this.pRAADRESSEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRACPDataGridViewTextBoxColumn
            // 
            this.pRACPDataGridViewTextBoxColumn.DataPropertyName = "PRA_CP";
            this.pRACPDataGridViewTextBoxColumn.HeaderText = "Code Postal";
            this.pRACPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRACPDataGridViewTextBoxColumn.Name = "pRACPDataGridViewTextBoxColumn";
            this.pRACPDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRAVILLEDataGridViewTextBoxColumn
            // 
            this.pRAVILLEDataGridViewTextBoxColumn.DataPropertyName = "PRA_VILLE";
            this.pRAVILLEDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.pRAVILLEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRAVILLEDataGridViewTextBoxColumn.Name = "pRAVILLEDataGridViewTextBoxColumn";
            this.pRAVILLEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRACOEFNOTORIETEDataGridViewTextBoxColumn
            // 
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.DataPropertyName = "PRA_COEFNOTORIETE";
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.HeaderText = "Coef Notoriété";
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.Name = "pRACOEFNOTORIETEDataGridViewTextBoxColumn";
            this.pRACOEFNOTORIETEDataGridViewTextBoxColumn.Width = 150;
            // 
            // tYPCODEDataGridViewTextBoxColumn
            // 
            this.tYPCODEDataGridViewTextBoxColumn.DataPropertyName = "TYP_CODE";
            this.tYPCODEDataGridViewTextBoxColumn.HeaderText = "Type";
            this.tYPCODEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tYPCODEDataGridViewTextBoxColumn.Name = "tYPCODEDataGridViewTextBoxColumn";
            this.tYPCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // FrmPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 625);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPraticien);
            this.Name = "FrmPraticien";
            this.Text = "FrmPraticien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRATICIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPraticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rAPPORTVISITEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACOEFNOTORIETEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRATICIENBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsPraticien;
    }
}