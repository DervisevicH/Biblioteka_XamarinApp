using Biblioteka_Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_WinForms.Knjige
{
    public partial class frmAdd : Form
    {
        private readonly ApiService _zanroviService = new ApiService("Zanrovi");
        private readonly ApiService _autoriService = new ApiService("Autori");
        private readonly ApiService _knjigeService = new ApiService("Knjige");

        KnjigeInsertUpdateRequest request = new KnjigeInsertUpdateRequest();        
        public frmAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

      
        private async void FrmAdd_Load(object sender, EventArgs e)
        {
            BindZanrovi();
            BindAutori();
            
        }

        private async void BindAutori()
        {
            var source = await _autoriService.Get<List<Biblioteka_Model.Autori>>(null);
            chbAutori.DataSource = source;
            chbAutori.DisplayMember = "ImePrezime";
            chbAutori.ValueMember = "AutorId";
        }

        private async void BindZanrovi()
        {
            var source = await _zanroviService.Get<List<Biblioteka_Model.Zanrovi>>(null);
            source.Insert(0, new Biblioteka_Model.Zanrovi() { Naziv = "Odaberite..." });
            cmbZanr.DataSource = source;
            cmbZanr.ValueMember = "ZanrId";
            cmbZanr.DisplayMember = "Naziv";
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                var autoriList = chbAutori.CheckedItems.Cast<Biblioteka_Model.Autori>().Select(x => x.AutorId).ToList();

                request.Naziv = txtNaziv.Text;
                request.Sifra = txtSifra.Text;
                request.ZanrId = Convert.ToInt32(cmbZanr.SelectedValue);
                request.DatumIzdavanja = godinaIzdavanja.Value;
                request.BrojStranica = Convert.ToInt32(txtBrStranica.Text);
                request.BrojDostupnihKnjiga = Convert.ToInt32(txtBrDostupnihKnjiga.Text);
                request.Sadrzaj = txtSadrzaj.Text;
                request.Autori = autoriList;


                Biblioteka_Model.Knjige entity = null;
                entity = await _knjigeService.Insert<Biblioteka_Model.Knjige>(request);
                if (entity != null)
                    MessageBox.Show("Uspješno ste sačuvali podatke", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;

            }
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtNaziv, "");
            }
        }

        private void CmbZanr_Validating(object sender, CancelEventArgs e)
        {
            if (cmbZanr.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbZanr, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(cmbZanr, "");
            }
        }

        private void TxtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSifra.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifra, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtSifra, "");
            }

        }

        private void TxtBrDostupnihKnjiga_Validating(object sender, CancelEventArgs e)
        {
            int val;
            if (int.TryParse(txtBrDostupnihKnjiga.Text, out val))
            {
                errorProvider.SetError(txtBrDostupnihKnjiga, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrDostupnihKnjiga, Properties.Resources.nmb_field);
            }
        }

        private void TxtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSlika.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSlika, Properties.Resources.req_field);
            }
            else
            {
                errorProvider.SetError(txtSlika, "");
            }
        }

        private void ChbAutori_Validating(object sender, CancelEventArgs e)
        {
            if (chbAutori.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(chbAutori, Properties.Resources.req_field);
            }
            else
                errorProvider.SetError(chbAutori, null);
        }

        private void TxtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSadrzaj.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSadrzaj, Properties.Resources.req_field);
            }
            else
                errorProvider.SetError(txtSadrzaj, null);
        }
    }
}
