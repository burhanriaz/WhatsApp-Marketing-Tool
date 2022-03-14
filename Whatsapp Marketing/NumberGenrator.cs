using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Imaging;
using Tesseract;
using System.Text.RegularExpressions;

namespace Whatsapp_Marketing
{

    public partial class NumberGenrator : Form
    {
        public NumberGenrator()
        {
            InitializeComponent();
        }
      /* 
       GetScreenshot function take screenshot of given Height and Width
      then Send to tesseract library to read text
      tesseract return text from image
       
       */
        private string GetSreenshot()
        {
            //int i = 1;
            Rectangle rect = new Rectangle(380, 135, 580, 470);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);


            //  bmp.Save(@"C:\Users\pc\Desktop\Whatsapp Marketing\Whatsapp Marketing\ScreenShot\{'" + i + @"'}img.png", ImageFormat.Png);
            // i = i + 1;

            TesseractEngine engine = new TesseractEngine("tessdata\\", "eng", EngineMode.Default);// create tesseract engine object

            Page page = engine.Process(bmp, PageSegMode.Auto); // page mode take image 
            string result = page.GetText();// return text from image using gettext function 

            return result; // return text where from function called
        }
      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            NumberGenrator_Load(null, null); //  form refresh

        }
        private void NumberGenrator_Load(object sender, EventArgs e)
        {
           
            MyNumbers.Load();// calling load function from Mynumber to load data in form load 
            txtcountryNameCb.Items.Clear(); 
            txtcountrycodeCb.Items.Clear(); 
            foreach (var item in Handler.myCountryList) // geting country list and then set into Combo box
            {
                txtcountrycodeCb.Items.Add(item.Code.ToString());  
                txtcountryNameCb.Items.Add(item.CountryName);
            }

            txtcountryNameCb.SelectedItem = "Pakistan";         // bydefaut set list itme 
                     
            NumberDGV.DataSource = MyNumbers.get_Datatable();  

            
        }
        private void btnGenrate_Click(object sender, EventArgs e)
        {
            
            if (txtpattren.Text == "" || txtquantity.Text == "")
            {                MessageBox.Show("Pattren & Quantity Can't Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    long number = Convert.ToInt64(txtpattren.Text);
                    long size = Convert.ToInt64(txtquantity.Text);
                    string num;

                    int i = 0;     
                    //here we can also use while loop to set find given number quantity Until size not match
                  //  while (size != Handler.myNumbersList.Count) 
                    
                        for(int j = 0; j < size; j++)
                    { 
                        num = "+" + txtcountrycodeCb.Text + Convert.ToString(number + j);
                        generated_number(num);
                        number = Convert.ToInt64(number);
                      //  i++;
                      
                                             
                    }
                 }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }

            }
           
            txtpattren.Text = "";
            txtquantity.Text = "";
            txtpattren.Focus();
            NumberGenrator_Load(null, null);
        }

        private void generated_number(String number)
        {

            var process = $"whatsapp://send?phone={number}";

            Process.Start(process);

            Thread.Sleep(1500);
            
            var bmp = GetSreenshot();
         
            string txt = "";
            txt = Regex.Replace(bmp.ToLower(), @"\s+", " ");
            //   if (txt !="phone number shared m url is invalid. " || txt != "phone numbershared vla w i invalid. " || txt != "phone numbershared vla w i invalid." || txt != "phone number shared vla w i invalid. " || txt != "phone numbershared m url is invalid." || txt != "starting chat" || txt != "starting chat ")
            if (txt == "" || txt == " ")
            {
                var nm = number;
                MyNumbers nb=new MyNumbers() {number= nm};
                nb.Save();
            }
            MyNumbers.Load();
        }


        private void txtcountryNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item=Handler.myCountryList.Find(x=> x.CountryName==txtcountryNameCb.Text);  
            if (item != null)
            {
                txtcountrycodeCb.SelectedItem = item.Code.ToString();
            }
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyNumbers.Clear();
            NumberGenrator_Load(null,null);

        }
        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Send_Bluk().ShowDialog();
            this.Show();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Handler.exportContact();
            NumberGenrator_Load(null, null);

        }

        private void lab3_Click(object sender, EventArgs e)
        {

        }

        private void txtcountrycodeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = Handler.myCountryList.Find(x => x.Code.ToString() == txtcountrycodeCb.Text);
            if (item != null)
            {
                txtcountryNameCb.SelectedItem = item.CountryName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
 }


