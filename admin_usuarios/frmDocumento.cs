using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace admin_us
{
    public partial class frmDocumento : Form
    {

        String rptact;
        Object st;
        String titulo;
        public frmDocumento(Object lista, String s)
        {
            InitializeComponent();
            this.rptact = Application.StartupPath+ "\\Reportes\\PhRmr3p0r7.rdlc";
            this.st = lista;
            this.titulo = s;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void FrmDocumento_Load(object sender, EventArgs e)
        {

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width + 282) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = rptact;
            ReportDataSource datos = new ReportDataSource();
            datos.Name = "DataSet1";
            datos.Value = st;
            ReportParameterCollection rP = new ReportParameterCollection();
            rP.Add(new ReportParameter("RP_Texto", titulo));
            this.reportViewer1.LocalReport.SetParameters(rP);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datos);
            this.reportViewer1.RefreshReport();
            
        }


    }
}
