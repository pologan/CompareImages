namespace CompareImages
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCompare = new System.Windows.Forms.Button();
            this.txtBoxOpnFile1 = new System.Windows.Forms.TextBox();
            this.txtBoxOpnFile2 = new System.Windows.Forms.TextBox();
            this.BtnOpnFile1 = new System.Windows.Forms.Button();
            this.BtnOpnFile2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(366, 151);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(75, 23);
            this.BtnCompare.TabIndex = 0;
            this.BtnCompare.Text = "Porównaj";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // txtBoxOpnFile1
            // 
            this.txtBoxOpnFile1.Location = new System.Drawing.Point(12, 35);
            this.txtBoxOpnFile1.Name = "txtBoxOpnFile1";
            this.txtBoxOpnFile1.Size = new System.Drawing.Size(296, 20);
            this.txtBoxOpnFile1.TabIndex = 1;
            // 
            // txtBoxOpnFile2
            // 
            this.txtBoxOpnFile2.Location = new System.Drawing.Point(492, 35);
            this.txtBoxOpnFile2.Name = "txtBoxOpnFile2";
            this.txtBoxOpnFile2.Size = new System.Drawing.Size(296, 20);
            this.txtBoxOpnFile2.TabIndex = 2;
            // 
            // BtnOpnFile1
            // 
            this.BtnOpnFile1.Location = new System.Drawing.Point(12, 61);
            this.BtnOpnFile1.Name = "BtnOpnFile1";
            this.BtnOpnFile1.Size = new System.Drawing.Size(75, 23);
            this.BtnOpnFile1.TabIndex = 3;
            this.BtnOpnFile1.Text = "Przeglądaj...";
            this.BtnOpnFile1.UseVisualStyleBackColor = true;
            this.BtnOpnFile1.Click += new System.EventHandler(this.BtnOpnFile1_Click);
            // 
            // BtnOpnFile2
            // 
            this.BtnOpnFile2.Location = new System.Drawing.Point(492, 61);
            this.BtnOpnFile2.Name = "BtnOpnFile2";
            this.BtnOpnFile2.Size = new System.Drawing.Size(75, 23);
            this.BtnOpnFile2.TabIndex = 4;
            this.BtnOpnFile2.Text = "Przeglądaj...";
            this.BtnOpnFile2.UseVisualStyleBackColor = true;
            this.BtnOpnFile2.Click += new System.EventHandler(this.BtnOpnFile2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pierwszy obraz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drugi obraz:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(366, 205);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(96, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Obraz podobny w: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpnFile2);
            this.Controls.Add(this.BtnOpnFile1);
            this.Controls.Add(this.txtBoxOpnFile2);
            this.Controls.Add(this.txtBoxOpnFile1);
            this.Controls.Add(this.BtnCompare);
            this.Name = "Form1";
            this.Text = "Comparing Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox txtBoxOpnFile1;
        private System.Windows.Forms.TextBox txtBoxOpnFile2;
        private System.Windows.Forms.Button BtnOpnFile1;
        private System.Windows.Forms.Button BtnOpnFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
    }
}

