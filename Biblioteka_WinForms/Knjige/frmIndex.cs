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

namespace Biblioteka_WinForms.Knjige
{
    public partial class frmIndex : Form
    {
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        private readonly ApiService _knjigeService = new ApiService("Knjige");

        public frmIndex()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmIndex_Load(object sender, EventArgs e)
        {
            var source = await _zanroviService.Get<List<Biblioteka_Model.Zanrovi>>(null);
            source.Insert(0, new Biblioteka_Model.Zanrovi { Naziv = "Odaberite..." });
            cmbZanrovi.DataSource = source;
            cmbZanrovi.ValueMember = "ZanrId";
            cmbZanrovi.DisplayMember = "Naziv";
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                KnjigeSearchRequest request = new KnjigeSearchRequest() { Naziv = txtNazivKnjige.Text, ZanrId = Convert.ToInt32(cmbZanrovi.SelectedValue) };
                var result = await _knjigeService.Get<List<Biblioteka_Model.Knjige>>(request);
                dgvKnjige.AutoGenerateColumns = false;
                dgvKnjige.DataSource = result;
            }
        }

        private void CmbZanrovi_Validating(object sender, CancelEventArgs e)
        {
            if (cmbZanrovi.SelectedIndex == 0 && String.IsNullOrEmpty(txtNazivKnjige.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbZanrovi,"Odaberite žanr ili unesite naziv knjige");
            }
            else
                errorProvider.SetError(cmbZanrovi, null);
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKnjige.SelectedRows[0].Cells[0].Value);
            frmEdit frm = new frmEdit(id);
            frm.ShowDialog();
        }
    }
}
