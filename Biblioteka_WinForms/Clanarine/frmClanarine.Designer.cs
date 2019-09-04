namespace Biblioteka_WinForms.Clanarine
{
    partial class frmClanarine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUredi = new System.Windows.Forms.Button();
            this.cmbClanovi = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dtpGodina = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.ClanarinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIzvjestaj);
            this.panel1.Controls.Add(this.btnUredi);
            this.panel1.Controls.Add(this.cmbClanovi);
            this.panel1.Controls.Add(this.btnPretraga);
            this.panel1.Controls.Add(this.dtpGodina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 153);
            this.panel1.TabIndex = 0;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(914, 44);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(162, 33);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // cmbClanovi
            // 
            this.cmbClanovi.FormattingEnabled = true;
            this.cmbClanovi.Location = new System.Drawing.Point(145, 44);
            this.cmbClanovi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClanovi.Name = "cmbClanovi";
            this.cmbClanovi.Size = new System.Drawing.Size(256, 30);
            this.cmbClanovi.TabIndex = 5;
            this.cmbClanovi.Validating += new System.ComponentModel.CancelEventHandler(this.CmbClanovi_Validating);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(712, 45);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(152, 32);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // dtpGodina
            // 
            this.dtpGodina.CustomFormat = "yyyy";
            this.dtpGodina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGodina.Location = new System.Drawing.Point(546, 47);
            this.dtpGodina.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGodina.Name = "dtpGodina";
            this.dtpGodina.ShowUpDown = true;
            this.dtpGodina.Size = new System.Drawing.Size(103, 29);
            this.dtpGodina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Član";
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.AllowUserToAddRows = false;
            this.dgvClanarine.AllowUserToDeleteRows = false;
            this.dgvClanarine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanarine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanarinaId,
            this.Clan,
            this.DatumUplate,
            this.DatumIsteka,
            this.Iznos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClanarine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClanarine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanarine.Location = new System.Drawing.Point(0, 153);
            this.dgvClanarine.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.ReadOnly = true;
            this.dgvClanarine.RowHeadersWidth = 51;
            this.dgvClanarine.RowTemplate.Height = 24;
            this.dgvClanarine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanarine.Size = new System.Drawing.Size(1171, 466);
            this.dgvClanarine.TabIndex = 1;
            // 
            // ClanarinaId
            // 
            this.ClanarinaId.DataPropertyName = "ClanarinaId";
            this.ClanarinaId.HeaderText = "ClanarinaId";
            this.ClanarinaId.MinimumWidth = 6;
            this.ClanarinaId.Name = "ClanarinaId";
            this.ClanarinaId.ReadOnly = true;
            this.ClanarinaId.Visible = false;
            // 
            // Clan
            // 
            this.Clan.DataPropertyName = "ImePrezime";
            this.Clan.HeaderText = "Član";
            this.Clan.MinimumWidth = 6;
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            // 
            // DatumUplate
            // 
            this.DatumUplate.DataPropertyName = "DatumUplate";
            this.DatumUplate.HeaderText = "Datum uplate";
            this.DatumUplate.MinimumWidth = 6;
            this.DatumUplate.Name = "DatumUplate";
            this.DatumUplate.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.MinimumWidth = 6;
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.MinimumWidth = 6;
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(914, 92);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(162, 33);
            this.btnIzvjestaj.TabIndex = 7;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.BtnIzvjestaj_Click);
            // 
            // frmClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 619);
            this.Controls.Add(this.dgvClanarine);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClanarine";
            this.Text = "Članarine";
            this.Load += new System.EventHandler(this.FrmClanarine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DateTimePicker dtpGodina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.ComboBox cmbClanovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanarinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}