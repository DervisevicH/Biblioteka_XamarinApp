﻿namespace Biblioteka_WinForms
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime ";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(214, 51);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(208, 22);
            this.txtKorisnickoIme.TabIndex = 1;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(214, 105);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(208, 22);
            this.txtLozinka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(330, 163);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(92, 28);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 228);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrijava;
    }
}