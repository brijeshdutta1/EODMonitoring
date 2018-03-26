using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODMonitoring
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;//.None; 
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            chart1.Series["WorkflowName"]["PixelPointWidth"] = "5";



            this.chart1.Series["WorkflowName"].Points.AddXY("Roll other dates", 30);
            this.chart1.Series["WorkflowName"].Points.AddXY("DWextractRates_Uni", 40);
            this.chart1.Series["WorkflowName"].Points.AddXY("Power Capacity Amortiser", 50);
            this.chart1.Series["WorkflowName"].Points.AddXY("Gas Storage Amortiser", 60);
            this.chart1.Series["WorkflowName"].Points.AddXY("B2B Reconcilation", 60);
            this.chart1.Series["WorkflowName"].Points.AddXY("Gas Storage Actuals Updater", 20);
            this.chart1.Series["WorkflowName"].Points.AddXY("Option Model Inputs - Exchange Options", 80);
            this.chart1.Series["WorkflowName"].Points.AddXY("Reporting DB Extract - EXPOSURE EOD", 100);
            this.chart1.Series["WorkflowName"].Points[7].Color = Color.Red;
            this.chart1.Series["WorkflowName"].Points.AddXY("Reporting DB Extract - PNL EXPLAINED EOD 1", 12);

            this.dataGridView1.Rows.Add("APM Batch Run", "COMPLETE", "", "");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
