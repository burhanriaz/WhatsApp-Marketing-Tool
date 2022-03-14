using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp_Marketing
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }
        int start_point = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start_point += 5;
            Myprogress.Value = start_point;
            percentage.Text = "" + start_point;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                this.Hide();
                new Login().ShowDialog();//
                this.Close();      
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
