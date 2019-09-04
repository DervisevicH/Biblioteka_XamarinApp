using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_WinForms
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knjige.frmIndex frm = new Knjige.frmIndex();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knjige.frmAdd frm = new Knjige.frmAdd();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void PretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autori.frmIndex frm = new Autori.frmIndex();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NoviAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autori.frmAdd frm = new Autori.frmAdd(null);
            frm.MdiParent = this;
            frm.Show();
        }

        private void PretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clanarine.frmClanarine frm = new Clanarine.frmClanarine();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void NovaČlanarinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clanarine.frmAdd frm = new Clanarine.frmAdd(null);
            frm.MdiParent = this;
            frm.Show();
        }

        private void AktivnaZaduženjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervacije.frmIndex frm = new Rezervacije.frmIndex();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NovaObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obavijesti.AddForm frm = new Obavijesti.AddForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PregledObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obavijesti.IndexForm frm = new Obavijesti.IndexForm();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
