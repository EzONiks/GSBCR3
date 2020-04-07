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
            this.btnValider = new System.Windows.Forms.Button();
            this.cbPraticien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des praticiens";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuitter.Location = new System.Drawing.Point(492, 142);
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
            this.label2.Location = new System.Drawing.Point(140, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValider.Location = new System.Drawing.Point(492, 218);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(192, 52);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbPraticien
            // 
            this.cbPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(76, 234);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(354, 33);
            this.cbPraticien.Sorted = true;
            this.cbPraticien.TabIndex = 7;
            // 
            // FrmPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 408);
            this.Controls.Add(this.cbPraticien);
            this.Controls.Add(this.btnValider);
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbPraticien;
    }
}