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
    public partial class frmAdd : Form
    {
        private readonly ApiService _autoriService = new ApiService("Autori");
        int? _id = null;
        public frmAdd(int ?id)
        {
            InitializeComponent();
            _id = id;
            this.AutoValidate = AutoValidate.Disable;
        }
        private async void FrmAdd_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await _autoriService.GetById<Biblioteka_Model.Autori>(_id.Value);
                txtIme.Text = entity.Ime;
                txtPrezime.Text = entity.Prezime;
                txtBiografija.Text = entity.Biografija;
            }
        }
        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                AutoriInsertUpdateRequest request = new AutoriInsertUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Biografija = txtBiografija.Text
                };
                Biblioteka_Model.Autori entity = null;
                if (_id.HasValue)
                {
                    request.AutorId = _id.Value;
                    entity = await _autoriService.Update<Biblioteka_Model.Autori>(_id.Value, request);
                }
                else
                {
                    entity = await _autoriService.Insert<Biblioteka_Model.Autori>(request);

                }
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste sačuvali podatke");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }
        
        #region Validation
        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtIme, "");
            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtPrezime, "");
            }
        }

        private void TxtBiografija_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtBiografija.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBiografija, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtBiografija, "");
            }
        }
        #endregion

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
