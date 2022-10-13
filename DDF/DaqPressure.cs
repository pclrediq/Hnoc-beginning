using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace DDF
{
    public partial class DaqPressure : Form
    {
        public DaqPressure()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_Analogin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Analogout_Click(object sender, EventArgs e)
        {

        }
    }
}
