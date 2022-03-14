using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Whatsapp_Marketing
{
    public partial class Send_Bluk : Form
    {
        public Send_Bluk()
        {
            InitializeComponent();

        }
        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            gunaLabel4.Text = "";
        }
        void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Send_Bluk_Load(null,null);
            txtdelay.Text = null;
            txtmsg.Text = null; 
            txtmsg.Focus();
        }

        private void Send_Bluk_Load(object sender, EventArgs e)
        {
            lab1.Hide();
            NumberDGV.DataSource = MyNumbers.get_Datatable();
            lab2.Text = "Total Number  " + Handler.myNumbersList.Count;

        }
        private void sendMsg_Click(object sender, EventArgs e)
        {
            if (txtdelay.Text == "" || txtmsg.Text == "")
            {
                MessageBox.Show("Delay Time or Message Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if ( NumberDGV.Rows.Count == 0)
                {
                    MessageBox.Show("No Number Available!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else 
                {
                    for (int i = 0; i < NumberDGV.Rows.Count; i++)
                    {
                        string number = NumberDGV.Rows[i].Cells[1].Value.ToString();  
                        var process = $"whatsapp://send?phone={number}&text={txtmsg.Text}";
                        Process myProcess = new Process();
                        Process.Start(process);
                        Thread.Sleep(1000 * Convert.ToInt32(txtdelay.Text));
                        SendKeys.Send("~");
                        lab1.Show();
                        lab1.Text = "Sent Messages " + (i + 1).ToString();
                    }
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (Handler.myNumbersList.Count > 0)
            {
                try
                {
                    OpenFileDialog op = new OpenFileDialog();
                    op.Title = "Please Select Contact File !!1";
                    op.Filter = "Excel |*.xlsx";
                    op.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        NumberDGV.DataSource = Handler.importContact(op.FileName);
                        lab2.Text = "Total Number  " + Convert.ToString(NumberDGV.Rows.Count);
                    }
                    MessageBox.Show("Excel File Import successfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("No Number Avialable !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void NumberDGV_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
           
        }

        private void txtdelay_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
    }

