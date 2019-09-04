namespace Biblioteka_WinForms.Rezervacije
{
    partial class frmEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.datumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.datumPreuzimanja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datumVracanja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtListaKnjiga = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum rezervacije";
            // 
            // datumRezervacije
            // 
            this.datumRezervacije.Location = new System.Drawing.Point(304, 50);
            this.datumRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.datumRezervacije.Name = "datumRezervacije";
            this.datumRezervacije.Size = new System.Drawing.Size(283, 29);
            this.datumRezervacije.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime i prezime člana";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Enabled = false;
            this.txtImePrezime.Location = new System.Drawing.Point(304, 117);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(283, 29);
            this.txtImePrezime.TabIndex = 3;
            // 
            // datumPreuzimanja
            // 
            this.datumPreuzimanja.Checked = false;
            this.datumPreuzimanja.CustomFormat = " ";
            this.datumPreuzimanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumPreuzimanja.Location = new System.Drawing.Point(304, 182);
            this.datumPreuzimanja.Margin = new System.Windows.Forms.Padding(4);
            this.datumPreuzimanja.Name = "datumPreuzimanja";
            this.datumPreuzimanja.ShowCheckBox = true;
            this.datumPreuzimanja.Size = new System.Drawing.Size(283, 29);
            this.datumPreuzimanja.TabIndex = 5;
            this.datumPreuzimanja.ValueChanged += new System.EventHandler(this.DatumPreuzimanja_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum preuzimanja";
            // 
            // datumVracanja
            // 
            this.datumVracanja.Checked = false;
            this.datumVracanja.CustomFormat = " ";
            this.datumVracanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumVracanja.Location = new System.Drawing.Point(304, 245);
            this.datumVracanja.Margin = new System.Windows.Forms.Padding(4);
            this.datumVracanja.Name = "datumVracanja";
            this.datumVracanja.ShowCheckBox = true;
            this.datumVracanja.Size = new System.Drawing.Size(283, 29);
            this.datumVracanja.TabIndex = 7;
            this.datumVracanja.ValueChanged += new System.EventHandler(this.DatumVracanja_ValueChanged);
            this.datumVracanja.Validating += new System.ComponentModel.CancelEventHandler(this.DatumVracanja_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum vraćanja";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(459, 500);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(129, 47);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista knjiga";
            // 
            // txtListaKnjiga
            // 
            this.txtListaKnjiga.Enabled = false;
            this.txtListaKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaKnjiga.ForeColor = System.Drawing.Color.Maroon;
            this.txtListaKnjiga.Location = new System.Drawing.Point(304, 316);
            this.txtListaKnjiga.Margin = new System.Windows.Forms.Padding(4);
            this.txtListaKnjiga.Multiline = true;
            this.txtListaKnjiga.Name = "txtListaKnjiga";
            this.txtListaKnjiga.Size = new System.Drawing.Size(283, 151);
            this.txtListaKnjiga.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 619);
            this.Controls.Add(this.txtListaKnjiga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.datumVracanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumPreuzimanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumRezervacije);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEdit";
            this.Text = "Zaduženje";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DateTimePicker datumPreuzimanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumVracanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtListaKnjiga;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}