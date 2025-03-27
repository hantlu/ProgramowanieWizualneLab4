namespace ProgramowanieWizualneLab4
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
            this.image = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.load = new System.Windows.Forms.Button();
            this.dziewiec = new System.Windows.Forms.RadioButton();
            this.osiemnascie = new System.Windows.Forms.RadioButton();
            this.dwadziescia_siedem = new System.Windows.Forms.RadioButton();
            this.rotate = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.flip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(295, 41);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(288, 387);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(31, 362);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(190, 66);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // dziewiec
            // 
            this.dziewiec.AutoSize = true;
            this.dziewiec.Location = new System.Drawing.Point(44, 41);
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.Size = new System.Drawing.Size(81, 20);
            this.dziewiec.TabIndex = 2;
            this.dziewiec.TabStop = true;
            this.dziewiec.Text = "90 stopni";
            this.dziewiec.UseVisualStyleBackColor = true;
            // 
            // osiemnascie
            // 
            this.osiemnascie.AutoSize = true;
            this.osiemnascie.Location = new System.Drawing.Point(44, 81);
            this.osiemnascie.Name = "osiemnascie";
            this.osiemnascie.Size = new System.Drawing.Size(88, 20);
            this.osiemnascie.TabIndex = 3;
            this.osiemnascie.TabStop = true;
            this.osiemnascie.Text = "180 stopni";
            this.osiemnascie.UseVisualStyleBackColor = true;
            // 
            // dwadziescia_siedem
            // 
            this.dwadziescia_siedem.AutoSize = true;
            this.dwadziescia_siedem.Location = new System.Drawing.Point(44, 119);
            this.dwadziescia_siedem.Name = "dwadziescia_siedem";
            this.dwadziescia_siedem.Size = new System.Drawing.Size(88, 20);
            this.dwadziescia_siedem.TabIndex = 4;
            this.dwadziescia_siedem.TabStop = true;
            this.dwadziescia_siedem.Text = "270 stopni";
            this.dwadziescia_siedem.UseVisualStyleBackColor = true;
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(31, 160);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(190, 64);
            this.rotate.TabIndex = 5;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(31, 241);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(190, 63);
            this.invert.TabIndex = 6;
            this.invert.Text = "Invert Colors";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(31, 310);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(190, 46);
            this.flip.TabIndex = 7;
            this.flip.Text = "Upside Down";
            this.flip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 465);
            this.Controls.Add(this.flip);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.dwadziescia_siedem);
            this.Controls.Add(this.osiemnascie);
            this.Controls.Add(this.dziewiec);
            this.Controls.Add(this.load);
            this.Controls.Add(this.image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.RadioButton dziewiec;
        private System.Windows.Forms.RadioButton osiemnascie;
        private System.Windows.Forms.RadioButton dwadziescia_siedem;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button flip;
    }
}

