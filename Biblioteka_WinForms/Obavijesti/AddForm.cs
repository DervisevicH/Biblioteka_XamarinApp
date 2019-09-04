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

namespace Biblioteka_WinForms.Obavijesti
{
    public partial class AddForm : Form
    {
        private readonly ApiService _service = new ApiService("Obavijesti");
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ObavijestiInsertRequest request = new ObavijestiInsertRequest()
                {
                    Naslov = txtNaslov.Text,
                    Sadrzaj = txtSadrzaj.Text,
                    DatumObjave = System.DateTime.Now,
                    KorisnikId=Global.PrijavljeniKorisnik.KorisnikId
                };
                Biblioteka_Model.Obavijesti entity = null;
               
                    entity = await _service.Insert<Biblioteka_Model.Obavijesti>(request);

                
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste sačuvali podatke");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void TxtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaslov.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslov, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtNaslov, "");
            }
        }

        private void TxtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSadrzaj.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSadrzaj, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtSadrzaj, "");
            }
        }
    }
}
