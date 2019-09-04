namespace Biblioteka_WinForms.Rezervacije
{
    partial class frmIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClanovi = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPreuzimanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKnjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Član biblioteke";
            // 
            // cmbClanovi
            // 
            this.cmbClanovi.FormattingEnabled = true;
            this.cmbClanovi.Location = new System.Drawing.Point(209, 87);
            this.cmbClanovi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClanovi.Name = "cmbClanovi";
            this.cmbClanovi.Size = new System.Drawing.Size(265, 30);
            this.cmbClanovi.TabIndex = 1;
            this.cmbClanovi.Validating += new System.ComponentModel.CancelEventHandler(this.CmbClanovi_Validating);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(588, 82);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(214, 37);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.ImePrezime,
            this.DatumRezervacije,
            this.DatumPreuzimanja,
            this.DatumVracanja,
            this.BrojKnjiga});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRezervacije.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRezervacije.Location = new System.Drawing.Point(0, 280);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(1314, 502);
            this.dgvRezervacije.TabIndex = 3;
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.MinimumWidth = 6;
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezimeClana";
            this.ImePrezime.HeaderText = "Ime i prezime člana";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.MinimumWidth = 6;
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            // 
            // DatumPreuzimanja
            // 
            this.DatumPreuzimanja.DataPropertyName = "DatumPreuzimanja";
            this.DatumPreuzimanja.HeaderText = "Datum preuzimanja";
            this.DatumPreuzimanja.MinimumWidth = 6;
            this.DatumPreuzimanja.Name = "DatumPreuzimanja";
            this.DatumPreuzimanja.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.DataPropertyName = "DatumVracanja";
            this.DatumVracanja.HeaderText = "Datum vraćanja";
            this.DatumVracanja.MinimumWidth = 6;
            this.DatumVracanja.Name = "DatumVracanja";
            this.DatumVracanja.ReadOnly = true;
            // 
            // BrojKnjiga
            // 
            this.BrojKnjiga.DataPropertyName = "BrojKnjiga";
            this.BrojKnjiga.HeaderText = "Broj knjiga";
            this.BrojKnjiga.MinimumWidth = 6;
            this.BrojKnjiga.Name = "BrojKnjiga";
            this.BrojKnjiga.ReadOnly = true;
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.Location = new System.Drawing.Point(855, 81);
            this.btnEvidencija.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(255, 38);
            this.btnEvidencija.TabIndex = 4;
            this.btnEvidencija.Text = "Evidentiraj zaduženje";
            this.btnEvidencija.UseVisualStyleBackColor = true;
            this.btnEvidencija.Click += new System.EventHandler(this.BtnEvidencija_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 782);
            this.Controls.Add(this.btnEvidencija);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbClanovi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "Zaduženja";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClanovi;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPreuzimanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKnjiga;
        private System.Windows.Forms.Button btnEvidencija;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}