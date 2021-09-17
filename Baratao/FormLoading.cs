using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baratao
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
                       
    
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBar.Value = startPoint;
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                FormLogin log = new FormLogin();
                this.Hide();
                log.Show();
            }
           
        }
       
        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
