using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_WinForms.Autori
{
    public partial class frmIndex : Form
    {
        private readonly ApiService autoriService = new ApiService("Autori");
        public frmIndex()
        {
            InitializeComponent();
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            AutoriSearchRequest request = new AutoriSearchRequest() { ImePrezime = txtPretraga.Text };

            var source = await autoriService.Get<List<Biblioteka_Model.Autori>>(request);
            dgvAutori.AutoGenerateColumns = false;
            dgvAutori.DataSource = source;            
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvAutori.SelectedRows[0].Cells[0].Value);
            frmAdd frm = new frmAdd(id);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindAutori();
            }
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            BindAutori();
        }

        private async void BindAutori()
        {
            var source = await autoriService.Get<List<Biblioteka_Model.Autori>>(null);
            dgvAutori.AutoGenerateColumns = false;
            dgvAutori.DataSource = source;
        }
    }
}
