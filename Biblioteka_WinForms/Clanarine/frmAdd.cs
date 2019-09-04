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
    public partial class frmAdd : Form
    {
        private readonly ApiService _korisniciService = new ApiService("Korisnici");
        private readonly ApiService _clanarineService = new ApiService("Clanarine");
        int? _id;
        public frmAdd(int? id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            _id = id;
        }

        private async void FrmAdd_Load(object sender, EventArgs e)
        {
            BindClanovi();
            if (_id.HasValue)
            {
                var entity = await _clanarineService.GetById<Biblioteka_Model.Clanarine>(_id);
                cmbClanovi.SelectedValue = entity.KorisnikId;
                cmbClanovi.Enabled = false;
                dtpDatumIsteka.Value = entity.DatumIsteka;
                dtpDatumUplate.Value = entity.DatumUplate;
                txtIznos.Text = entity.Iznos.ToString();
            }
        }

        private async void BindClanovi()
        {
            var source = await _korisniciService.Get<List<Biblioteka_Model.Korisnici>>(null);
            source.Insert(0, new Biblioteka_Model.Korisnici { ImePrezime = "Odaberite..." });
            cmbClanovi.DataSource = source;
            cmbClanovi.ValueMember = "KorisnikId";
            cmbClanovi.DisplayMember = "ImePrezime";
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ClanarineInsertUpdateRequest request = new ClanarineInsertUpdateRequest()
                {
                    KorisnikId = Convert.ToInt32(cmbClanovi.SelectedValue),
                    DatumUplate = dtpDatumUplate.Value,
                    DatumIsteka = dtpDatumIsteka.Value,
                    Iznos = Convert.ToDecimal(txtIznos.Text)
                };
                Biblioteka_Model.Clanarine entity = null;
                if (_id.HasValue)
                {
                    request.ClanarinaId = _id.Value;
                    entity = await _clanarineService.Update<Biblioteka_Model.Clanarine>(_id.Value, request);
                }
                else
                {
                    entity = await _clanarineService.Insert<Biblioteka_Model.Clanarine>(request);
                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste sačuvali podatke", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Validation
        private void DtpDatumIsteka_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDatumUplate.Value >= dtpDatumIsteka.Value || dtpDatumIsteka.Value.Month == dtpDatumUplate.Value.Month)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpDatumIsteka, "Datum isteka ne može biti manji od datuma uplate. Mjesec uplate i isteka ne mogu biti isti.");
            }
            else
                errorProvider.SetError(dtpDatumIsteka, null);
        }

        private void TxtIznos_Validating(object sender, CancelEventArgs e)
        {
            int val;
            if (int.TryParse(txtIznos.Text, out val))
            {
                errorProvider.SetError(txtIznos, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtIznos, Properties.Resources.nmb_field);
            }
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

        #endregion

    }
}
