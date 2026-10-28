using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemMangec
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          progressBar1.Value = 0;
            timer1.Start();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimer.Text = "Loading ...  %" + progressBar1.Value;
            progressBar1.Value+=5;
            if (progressBar1.Value >= 100)
            {
                labTimer.Text = "Loading ...  %" + progressBar1.Value;
                timer1.Stop();
                this.Close();
              
            }
        }

        private void labTimer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
