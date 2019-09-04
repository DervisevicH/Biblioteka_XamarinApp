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
    public partial class frmEdit : Form
    {
        private readonly ApiService _rezervacijeService = new ApiService("Rezervacije");
        int? _id = null;
        public frmEdit(int ?id)
        {
            InitializeComponent();
            _id = id;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmEdit_Load(object sender, EventArgs e)
        {
            var entity = await _rezervacijeService.GetById<Biblioteka_Model.Rezervacije>(_id);
            if (entity.DatumPreuzimanja != null)
            {
                datumPreuzimanja.Value = entity.DatumPreuzimanja.Value;
                datumPreuzimanja.Enabled = false;
                datumPreuzimanja.Checked = false;
            }
            if (entity.DatumVracanja != null)
            {
                datumVracanja.Value = entity.DatumVracanja.Value;
                datumVracanja.Enabled = false;
                datumVracanja.Checked = false;
            }
            datumRezervacije.Value = entity.DatumRezervacije;
            datumRezervacije.Enabled = false;
            datumPreuzimanja.Checked = false;

            txtImePrezime.Text = entity.ImePrezimeClana;
            txtListaKnjiga.Text = entity.listaKnjiga;
        }

        private void DatumPreuzimanja_ValueChanged(object sender, EventArgs e)
        {
            datumPreuzimanja.CustomFormat = "dd/MM/yyyy";
        }

        private void DatumVracanja_ValueChanged(object sender, EventArgs e)
        {
            datumVracanja.CustomFormat = "dd/MM/yyyy";

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var entity = await _rezervacijeService.GetById<Biblioteka_Model.Rezervacije>(_id);

                RezervacijeUpdateRequest request = new RezervacijeUpdateRequest();
                 if (datumPreuzimanja.Checked == true)
                    request.DatumPreuzimanja = datumPreuzimanja.Value;
                else
                    request.DatumPreuzimanja = entity.DatumPreuzimanja;
                if (datumVracanja.Checked == true)
                    request.DatumVracanja = datumVracanja.Value;
                else
                {
                    request.DatumVracanja = entity.DatumVracanja;
                    request.Zavrsena = false;
                }
               
                request.DatumRezervacije = entity.DatumRezervacije;
                request.RezervacijaId = _id.Value;
                request.KorisnikId = entity.KorisnikId;
                Biblioteka_Model.Rezervacije result = null;
                result = await _rezervacijeService.Update<Biblioteka_Model.Rezervacije>(_id.Value, request);
                if (result != null)
                {
                    MessageBox.Show("Uspješno ste sačuvali podatke");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void DatumVracanja_Validating(object sender, CancelEventArgs e)
        {
            if (datumVracanja.Value < datumPreuzimanja.Value)
            {
                e.Cancel = true;
                errorProvider.SetError(datumVracanja, "Datum vraćanja ne može biti manji od datuma preuzimanja");
            }
            else
            {
                errorProvider.SetError(datumVracanja, null);
            }
        }
    }
}
