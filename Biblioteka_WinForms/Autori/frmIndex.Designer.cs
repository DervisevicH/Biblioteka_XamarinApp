namespace Biblioteka_WinForms.Autori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.AutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biografija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(178, 64);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(263, 29);
            this.txtPretraga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime i prezime";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(552, 58);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(147, 36);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // dgvAutori
            // 
            this.dgvAutori.AllowUserToAddRows = false;
            this.dgvAutori.AllowUserToDeleteRows = false;
            this.dgvAutori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorId,
            this.ImePrezime,
            this.Biografija});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutori.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAutori.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAutori.Location = new System.Drawing.Point(0, 172);
            this.dgvAutori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.ReadOnly = true;
            this.dgvAutori.RowHeadersWidth = 51;
            this.dgvAutori.RowTemplate.Height = 24;
            this.dgvAutori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutori.Size = new System.Drawing.Size(1000, 447);
            this.dgvAutori.TabIndex = 3;
            // 
            // AutorId
            // 
            this.AutorId.DataPropertyName = "AutorId";
            this.AutorId.HeaderText = "AutorId";
            this.AutorId.MinimumWidth = 6;
            this.AutorId.Name = "AutorId";
            this.AutorId.ReadOnly = true;
            this.AutorId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Biografija
            // 
            this.Biografija.DataPropertyName = "Biografija";
            this.Biografija.HeaderText = "Biografija";
            this.Biografija.MinimumWidth = 6;
            this.Biografija.Name = "Biografija";
            this.Biografija.ReadOnly = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(706, 58);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(139, 36);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIndex";
            this.Text = "Autori";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biografija;
        private System.Windows.Forms.Button btnUredi;
    }
}