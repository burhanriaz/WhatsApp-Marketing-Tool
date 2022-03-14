using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Whatsapp_Marketing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        
        }
      
        string password = "1234";


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            login_Load(null, null);
            txtpassword.Text = null;
            txtpassword.Focus();    
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtpassword.Text == password)
            {
                this.Hide();
                new NumberGenrator().ShowDialog();
                this.Close();
            }
            else
            {

                DialogResult result = MessageBox.Show("Wrong Password..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {

                    txtpassword.Text = "";
                    txtpassword.Focus();

                }
            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            
        }
      
    }
    
}
