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

namespace Biblioteka_WinForms.Clanarine
{
    public partial class frmClanarine : Form
    {
        private readonly ApiService _korisniciService = new ApiService("Korisnici");
        private readonly ApiService _clanarineService = new ApiService("Clanarine");

        public List<Biblioteka_Model.Clanarine> lista;
        public frmClanarine()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }


        private void FrmClanarine_Load(object sender, EventArgs e)
        {
            BindClanove();
        }

        private async void BindClanove()
        {
            var source = await _korisniciService.Get<List<Biblioteka_Model.Korisnici>>(null);
            source.Insert(0, new Biblioteka_Model.Korisnici() { ImePrezime = "Odaberite..." });
            cmbClanovi.DataSource = source;
            cmbClanovi.ValueMember = "KorisnikId";
            cmbClanovi.DisplayMember = "ImePrezime";
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ClanarineSearchRequest request = new ClanarineSearchRequest()
                {
                    ClanId = Convert.ToInt32(cmbClanovi.SelectedValue),
                    Godina = dtpGodina.Value
                };
                var source = await _clanarineService.Get<List<Biblioteka_Model.Clanarine>>(request);
                dgvClanarine.AutoGenerateColumns = false;
                dgvClanarine.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClanarine.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClanarine.DataSource = source;
                lista = new List<Biblioteka_Model.Clanarine>();
                lista = source;
            }
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvClanarine.SelectedRows[0].Cells[0].Value);
            frmAdd frm = new frmAdd(id);
            frm.ShowDialog();
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

        private void BtnIzvjestaj_Click(object sender, EventArgs e)
        {
            Izvjestaji.ClanarineViewForms frm = new Izvjestaji.ClanarineViewForms();
            frm.listaClanarina = lista;
            frm.ImePrezime = lista.Select(x=>x.ImePrezime).First();
            frm.Show();
        }
    }
}
