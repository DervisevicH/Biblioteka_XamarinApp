namespace Biblioteka_WinForms.Clanarine
{
    partial class frmAdd
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
            this.cmbClanovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumIsteka = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Član";
            // 
            // cmbClanovi
            // 
            this.cmbClanovi.FormattingEnabled = true;
            this.cmbClanovi.Location = new System.Drawing.Point(49, 59);
            this.cmbClanovi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClanovi.Name = "cmbClanovi";
            this.cmbClanovi.Size = new System.Drawing.Size(291, 30);
            this.cmbClanovi.TabIndex = 1;
            this.cmbClanovi.Validating += new System.ComponentModel.CancelEventHandler(this.CmbClanovi_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum uplate";
            // 
            // dtpDatumUplate
            // 
            this.dtpDatumUplate.Location = new System.Drawing.Point(49, 168);
            this.dtpDatumUplate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumUplate.Name = "dtpDatumUplate";
            this.dtpDatumUplate.Size = new System.Drawing.Size(291, 29);
            this.dtpDatumUplate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum isteka";
            // 
            // dtpDatumIsteka
            // 
            this.dtpDatumIsteka.Location = new System.Drawing.Point(53, 279);
            this.dtpDatumIsteka.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumIsteka.Name = "dtpDatumIsteka";
            this.dtpDatumIsteka.Size = new System.Drawing.Size(288, 29);
            this.dtpDatumIsteka.TabIndex = 5;
            this.dtpDatumIsteka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatumIsteka_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(202, 464);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(139, 30);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iznos";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(53, 387);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(288, 29);
            this.txtIznos.TabIndex = 8;
            this.txtIznos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIznos_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(76, 464);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(119, 30);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 599);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpDatumIsteka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumUplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClanovi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Članarina";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClanovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumUplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumIsteka;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}