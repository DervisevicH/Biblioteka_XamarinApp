using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_WinForms.Izvjestaji
{
    public partial class ClanarineViewForms : Form
    {
        public List<Biblioteka_Model.Clanarine> listaClanarina { get; set; }
        public string ImePrezime { get; set; }
        public ClanarineViewForms()
        {
            InitializeComponent();
        }

        private void ClanarineViewForms_Load(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("dsClanarine",listaClanarina);
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Clan", ImePrezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumIzvjestaja", System.DateTime.Now.ToShortDateString()));
            this.reportViewer1.RefreshReport();

        }
    }
}
