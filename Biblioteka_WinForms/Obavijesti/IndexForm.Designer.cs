namespace Biblioteka_WinForms.Obavijesti
{
    partial class IndexForm
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpretraga = new System.Windows.Forms.Button();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.ObavijestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(150, 70);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(246, 29);
            this.txtNaslov.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // btnpretraga
            // 
            this.btnpretraga.Location = new System.Drawing.Point(451, 67);
            this.btnpretraga.Margin = new System.Windows.Forms.Padding(4);
            this.btnpretraga.Name = "btnpretraga";
            this.btnpretraga.Size = new System.Drawing.Size(228, 32);
            this.btnpretraga.TabIndex = 2;
            this.btnpretraga.Text = "Pretraži";
            this.btnpretraga.UseVisualStyleBackColor = true;
            this.btnpretraga.Click += new System.EventHandler(this.Btnpretraga_Click);
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObavijesti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestId,
            this.Naslov,
            this.Sadrzaj});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObavijesti.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvObavijesti.Location = new System.Drawing.Point(0, 204);
            this.dgvObavijesti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowHeadersWidth = 51;
            this.dgvObavijesti.RowTemplate.Height = 24;
            this.dgvObavijesti.Size = new System.Drawing.Size(954, 483);
            this.dgvObavijesti.TabIndex = 3;
            // 
            // ObavijestId
            // 
            this.ObavijestId.DataPropertyName = "ObavijestId";
            this.ObavijestId.HeaderText = "ObavijestId";
            this.ObavijestId.MinimumWidth = 6;
            this.ObavijestId.Name = "ObavijestId";
            this.ObavijestId.ReadOnly = true;
            this.ObavijestId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadržaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 687);
            this.Controls.Add(this.dgvObavijesti);
            this.Controls.Add(this.btnpretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaslov);
            this.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpretraga;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
    }
}