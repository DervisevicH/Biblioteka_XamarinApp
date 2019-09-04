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

namespace Biblioteka_WinForms.Rezervacije
{
    public partial class frmIndex : Form
    {
        private readonly ApiService _clanoviService = new ApiService("Korisnici");
        private readonly ApiService _rezervacijeService = new ApiService("Rezervacije");
        public frmIndex()
        {
            InitializeComponent();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            BindClanove();
        }       

        private async void BindClanove()
        {
            var source = await _clanoviService.Get<List<Biblioteka_Model.Korisnici>>(null);
            source.Insert(0, new Biblioteka_Model.Korisnici() { ImePrezime = "Odaberite..." });
            cmbClanovi.DataSource = source;
            cmbClanovi.ValueMember = "KorisnikId";
            cmbClanovi.DisplayMember = "ImePrezime";
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                RezervacijeSearchRequest request = new RezervacijeSearchRequest() { ClanId = Convert.ToInt32(cmbClanovi.SelectedValue) };
                var result = await _rezervacijeService.Get<List<Biblioteka_Model.Rezervacije>>(request);
                dgvRezervacije.AutoGenerateColumns = false;
                dgvRezervacije.DataSource = result;
            }
        }

        private async void BtnEvidencija_Click(object sender, EventArgs e)
        {
            var rezervacijaId = Convert.ToInt32(dgvRezervacije.SelectedRows[0].Cells[0].Value);
            frmEdit frm = new frmEdit(rezervacijaId);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                RezervacijeSearchRequest request = new RezervacijeSearchRequest() { ClanId = Convert.ToInt32(cmbClanovi.SelectedValue) };
                var result = await _rezervacijeService.Get<List<Biblioteka_Model.Rezervacije>>(request);
                dgvRezervacije.AutoGenerateColumns = false;
                dgvRezervacije.DataSource = result;
            };
        }

        private void CmbClanovi_Validating(object sender, CancelEventArgs e)
        {
            if (cmbClanovi.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbClanovi, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(cmbClanovi, null);
            }
        }
    }
    
}
