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
    public partial class IndexForm : Form
    {
        private readonly ApiService service = new ApiService("Obavijesti");

        public IndexForm()
        {
            InitializeComponent();
        }

        private async void Btnpretraga_Click(object sender, EventArgs e)
        {
            ObavijestSearchRequest request = new ObavijestSearchRequest() { Naslov = txtNaslov.Text };

            var source = await service.Get<List<Biblioteka_Model.Obavijesti>>(request);
            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = source;
        }

        private async void IndexForm_Load(object sender, EventArgs e)
        {
            var source = await service.Get<List<Biblioteka_Model.Obavijesti>>(null);
            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = source;
        }
    }
}
