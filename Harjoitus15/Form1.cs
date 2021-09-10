using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Harjoitus15
{
    public partial class StopwatchForm : Form
    {

        private Stopwatch stopWatch;


        public StopwatchForm()
        {
            InitializeComponent();
        }

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
