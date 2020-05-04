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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticien));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.cbPraticien = new System.Windows.Forms.ComboBox();
            this.btnRapport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ucPratictien1 = new GSBCR.UC.UcPratictien();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des praticiens";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuitter.Location = new System.Drawing.Point(480, 142);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(192, 52);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // cbPraticien
            // 
            this.cbPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(64, 234);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(354, 33);
            this.cbPraticien.Sorted = true;
            this.cbPraticien.TabIndex = 7;
            this.cbPraticien.SelectedIndexChanged += new System.EventHandler(this.cbPraticien_SelectedIndexChanged);
            // 
            // btnRapport
            // 
            this.btnRapport.Location = new System.Drawing.Point(506, 660);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(182, 46);
            this.btnRapport.TabIndex = 9;
            this.btnRapport.Text = "Voir les rapports";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 674);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aucun rapports";
            // 
            // ucPratictien1
            // 
            this.ucPratictien1.Location = new System.Drawing.Point(48, 297);
            this.ucPratictien1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucPratictien1.Name = "ucPratictien1";
            this.ucPratictien1.pRATICIEN = null;
            this.ucPratictien1.Size = new System.Drawing.Size(608, 369);
            this.ucPratictien1.TabIndex = 8;
            // 
            // FrmPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 748);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.ucPratictien1);
            this.Controls.Add(this.cbPraticien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPraticien";
            this.Text = "GSBCR";
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRANOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRAVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACOEFNOTORIETEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.ComboBox cbPraticien;
        private UC.UcPratictien ucPratictien1;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Label label4;
    }
}