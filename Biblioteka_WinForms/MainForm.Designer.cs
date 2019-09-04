namespace Biblioteka_WinForms
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.zaduženjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivnaZaduženjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaČlanarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaObavijestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledObavijestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaduženjaToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.autoriToolStripMenuItem,
            this.članarineToolStripMenuItem,
            this.obavijestiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // zaduženjaToolStripMenuItem
            // 
            this.zaduženjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivnaZaduženjaToolStripMenuItem});
            this.zaduženjaToolStripMenuItem.Name = "zaduženjaToolStripMenuItem";
            this.zaduženjaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.zaduženjaToolStripMenuItem.Text = "Zaduženja";
            // 
            // aktivnaZaduženjaToolStripMenuItem
            // 
            this.aktivnaZaduženjaToolStripMenuItem.Name = "aktivnaZaduženjaToolStripMenuItem";
            this.aktivnaZaduženjaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.aktivnaZaduženjaToolStripMenuItem.Text = "Aktivna zaduženja";
            this.aktivnaZaduženjaToolStripMenuItem.Click += new System.EventHandler(this.AktivnaZaduženjaToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.novaKnjigaToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // novaKnjigaToolStripMenuItem
            // 
            this.novaKnjigaToolStripMenuItem.Name = "novaKnjigaToolStripMenuItem";
            this.novaKnjigaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.novaKnjigaToolStripMenuItem.Text = "Nova knjiga";
            this.novaKnjigaToolStripMenuItem.Click += new System.EventHandler(this.NovaKnjigaToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.noviAutorToolStripMenuItem});
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.pretragaToolStripMenuItem1.Text = "Pretraga ";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.PretragaToolStripMenuItem1_Click);
            // 
            // noviAutorToolStripMenuItem
            // 
            this.noviAutorToolStripMenuItem.Name = "noviAutorToolStripMenuItem";
            this.noviAutorToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.noviAutorToolStripMenuItem.Text = "Novi autor";
            this.noviAutorToolStripMenuItem.Click += new System.EventHandler(this.NoviAutorToolStripMenuItem_Click);
            // 
            // članarineToolStripMenuItem
            // 
            this.članarineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.novaČlanarinaToolStripMenuItem});
            this.članarineToolStripMenuItem.Name = "članarineToolStripMenuItem";
            this.članarineToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.članarineToolStripMenuItem.Text = "Članarine";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(191, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.PretragaToolStripMenuItem2_Click);
            // 
            // novaČlanarinaToolStripMenuItem
            // 
            this.novaČlanarinaToolStripMenuItem.Name = "novaČlanarinaToolStripMenuItem";
            this.novaČlanarinaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.novaČlanarinaToolStripMenuItem.Text = "Nova članarina";
            this.novaČlanarinaToolStripMenuItem.Click += new System.EventHandler(this.NovaČlanarinaToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaObavijestToolStripMenuItem,
            this.pregledObavijestToolStripMenuItem});
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            // 
            // novaObavijestToolStripMenuItem
            // 
            this.novaObavijestToolStripMenuItem.Name = "novaObavijestToolStripMenuItem";
            this.novaObavijestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novaObavijestToolStripMenuItem.Text = "Nova obavijest";
            this.novaObavijestToolStripMenuItem.Click += new System.EventHandler(this.NovaObavijestToolStripMenuItem_Click);
            // 
            // pregledObavijestToolStripMenuItem
            // 
            this.pregledObavijestToolStripMenuItem.Name = "pregledObavijestToolStripMenuItem";
            this.pregledObavijestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledObavijestToolStripMenuItem.Text = "Pregled obavijest";
            this.pregledObavijestToolStripMenuItem.Click += new System.EventHandler(this.PregledObavijestToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem zaduženjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivnaZaduženjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noviAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članarineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novaČlanarinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaObavijestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledObavijestToolStripMenuItem;
    }
}



