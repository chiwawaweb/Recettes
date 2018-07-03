namespace Recettes.Forms
{
    partial class MainForm
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
            this.BtnNouvelleRecette = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNouvelleRecette
            // 
            this.BtnNouvelleRecette.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouvelleRecette.Location = new System.Drawing.Point(287, 41);
            this.BtnNouvelleRecette.Name = "BtnNouvelleRecette";
            this.BtnNouvelleRecette.Size = new System.Drawing.Size(204, 102);
            this.BtnNouvelleRecette.TabIndex = 0;
            this.BtnNouvelleRecette.Text = "Nouvelle recette";
            this.BtnNouvelleRecette.UseVisualStyleBackColor = true;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Location = new System.Drawing.Point(287, 389);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(204, 45);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 468);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnNouvelleRecette);
            this.Name = "MainForm";
            this.Text = "Recettes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNouvelleRecette;
        private System.Windows.Forms.Button BtnQuitter;
    }
}