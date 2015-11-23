namespace LangtonAmeisen
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFeld = new System.Windows.Forms.PictureBox();
            this.statusLeiste = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEinzelschritt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeld)).BeginInit();
            this.statusLeiste.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFeld
            // 
            this.pbFeld.Location = new System.Drawing.Point(13, 13);
            this.pbFeld.Name = "pbFeld";
            this.pbFeld.Size = new System.Drawing.Size(400, 400);
            this.pbFeld.TabIndex = 0;
            this.pbFeld.TabStop = false;
            this.pbFeld.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFeld_Paint);
            // 
            // statusLeiste
            // 
            this.statusLeiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusLeiste.Location = new System.Drawing.Point(0, 458);
            this.statusLeiste.Name = "statusLeiste";
            this.statusLeiste.Size = new System.Drawing.Size(429, 22);
            this.statusLeiste.TabIndex = 1;
            this.statusLeiste.Text = "OK";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(23, 17);
            this.statusLabel.Text = "OK";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 419);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnEinzelschritt
            // 
            this.btnEinzelschritt.Location = new System.Drawing.Point(175, 418);
            this.btnEinzelschritt.Name = "btnEinzelschritt";
            this.btnEinzelschritt.Size = new System.Drawing.Size(75, 23);
            this.btnEinzelschritt.TabIndex = 4;
            this.btnEinzelschritt.Text = "Einzelschritt";
            this.btnEinzelschritt.UseVisualStyleBackColor = true;
            this.btnEinzelschritt.Click += new System.EventHandler(this.btnEinzelschritt_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 480);
            this.Controls.Add(this.btnEinzelschritt);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.statusLeiste);
            this.Controls.Add(this.pbFeld);
            this.Name = "Hauptfenster";
            this.Text = "Langton Ameisen";
            ((System.ComponentModel.ISupportInitialize)(this.pbFeld)).EndInit();
            this.statusLeiste.ResumeLayout(false);
            this.statusLeiste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFeld;
        private System.Windows.Forms.StatusStrip statusLeiste;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEinzelschritt;
    }
}

