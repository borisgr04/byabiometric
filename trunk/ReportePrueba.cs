using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintNetSample
{
    public partial class ReportePrueba : Form
    {
        public ReportePrueba()
        {
            InitializeComponent();
        }

        private void ReportePrueba_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
