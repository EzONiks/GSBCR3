namespace GSBCR.UI
{
    partial class FrmDetailPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailPraticien));

            this.label1 = new System.Windows.Forms.Label();
            this.btnVoirRap = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.ucPratictien1 = new GSBCR.UC.UcPratictien();
            this.SuspendLayout();
            // btnVoirRap
            // 
            this.btnVoirRap.Location = new System.Drawing.Point(411, 23);
            this.btnVoirRap.Name = "btnVoirRap";
            this.btnVoirRap.Size = new System.Drawing.Size(149, 38);
            this.btnVoirRap.TabIndex = 8;
            this.btnVoirRap.Text = "Voir les rapports";
            this.btnVoirRap.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(581, 23);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 38);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ucPratictien1
            // 
            this.ucPratictien1.Location = new System.Drawing.Point(13, 69);
            this.ucPratictien1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPratictien1.Name = "ucPratictien1";
            this.ucPratictien1.pRATICIEN = null;
            this.ucPratictien1.Size = new System.Drawing.Size(762, 503);
            this.ucPratictien1.TabIndex = 10;
            // ucPratictien1
            // 
            this.ucPratictien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPratictien1.Location = new System.Drawing.Point(7, 24);
            this.ucPratictien1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPratictien1.Name = "ucPratictien1";
            this.ucPratictien1.pRATICIEN = null;
            this.ucPratictien1.Size = new System.Drawing.Size(349, 254);
            this.ucPratictien1.TabIndex = 0;
            // 
            // FrmDetailPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 562);
            this.Controls.Add(this.ucPratictien1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnVoirRap);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(381, 309);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetailPraticien";
            this.Text = "GSBCR";
            this.Load += new System.EventHandler(this.FrmDetailPraticien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoirRap;
        private System.Windows.Forms.Button btnQuit;
        private UC.UcPratictien ucPratictien1;
    }
}