namespace Picsi
{
    partial class Picsi
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.picBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxInfos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(34, 51);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(100, 25);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choisir un fichier";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // picBrowserDialog
            // 
            this.picBrowserDialog.Title = "Choisissez une photo";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(34, 129);
            this.pictureBox.MaximumSize = new System.Drawing.Size(580, 450);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(580, 450);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // textBoxInfos
            // 
            this.textBoxInfos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxInfos.Location = new System.Drawing.Point(155, 12);
            this.textBoxInfos.Multiline = true;
            this.textBoxInfos.Name = "textBoxInfos";
            this.textBoxInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfos.Size = new System.Drawing.Size(459, 100);
            this.textBoxInfos.TabIndex = 5;
            // 
            // Picsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 600);
            this.Controls.Add(this.textBoxInfos);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Picsi";
            this.Text = "Picsi";
            this.Load += new System.EventHandler(this.Picsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog picBrowserDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxInfos;
    }
}

