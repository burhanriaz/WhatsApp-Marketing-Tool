namespace Whatsapp_Marketing
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lab1 = new Guna.UI.WinForms.GunaLabel();
            this.laboldpass = new Guna.UI.WinForms.GunaLabel();
            this.txtpassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnlogin = new Guna.UI.WinForms.GunaButton();
            this.btmExit = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.filtertbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtertbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.lab1.ForeColor = System.Drawing.Color.White;
            this.lab1.Location = new System.Drawing.Point(267, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(104, 40);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Login";
            this.lab1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // laboldpass
            // 
            this.laboldpass.AutoSize = true;
            this.laboldpass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laboldpass.ForeColor = System.Drawing.Color.Black;
            this.laboldpass.Location = new System.Drawing.Point(60, 128);
            this.laboldpass.Name = "laboldpass";
            this.laboldpass.Size = new System.Drawing.Size(90, 22);
            this.laboldpass.TabIndex = 2;
            this.laboldpass.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtpassword.LineColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(274, 118);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(139, 32);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.AnimationHoverSpeed = 0.07F;
            this.btnlogin.AnimationSpeed = 0.03F;
            this.btnlogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnlogin.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnlogin.BorderColor = System.Drawing.Color.Black;
            this.btnlogin.BorderSize = 3;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnlogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlogin.ImageSize = new System.Drawing.Size(33, 33);
            this.btnlogin.Location = new System.Drawing.Point(55, 237);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnlogin.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnlogin.OnHoverImage = null;
            this.btnlogin.OnPressedColor = System.Drawing.Color.Red;
            this.btnlogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlogin.Size = new System.Drawing.Size(139, 42);
            this.btnlogin.TabIndex = 30;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btmExit
            // 
            this.btmExit.Animated = true;
            this.btmExit.AnimationHoverSpeed = 0.07F;
            this.btmExit.AnimationSpeed = 0.03F;
            this.btmExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btmExit.BaseColor = System.Drawing.Color.DarkCyan;
            this.btmExit.BorderColor = System.Drawing.Color.Black;
            this.btmExit.BorderSize = 3;
            this.btmExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btmExit.FocusedColor = System.Drawing.Color.Empty;
            this.btmExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmExit.ForeColor = System.Drawing.Color.White;
            this.btmExit.Image = ((System.Drawing.Image)(resources.GetObject("btmExit.Image")));
            this.btmExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btmExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btmExit.Location = new System.Drawing.Point(475, 237);
            this.btmExit.Name = "btmExit";
            this.btmExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btmExit.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btmExit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btmExit.OnHoverImage = null;
            this.btmExit.OnPressedColor = System.Drawing.Color.Red;
            this.btmExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btmExit.Size = new System.Drawing.Size(139, 42);
            this.btmExit.TabIndex = 29;
            this.btmExit.Text = "Exit";
            this.btmExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.BorderSize = 3;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.ImageSize = new System.Drawing.Size(36, 36);
            this.btnRefresh.Location = new System.Drawing.Point(274, 237);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Red;
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(139, 42);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Black;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 43);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(10, 283);
            this.gunaPanel2.TabIndex = 132;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 10);
            this.panel3.TabIndex = 135;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lab1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 43);
            this.panel1.TabIndex = 137;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(651, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 336);
            this.panel2.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 131;
            // 
            // filtertbBindingSource
            // 
            this.filtertbBindingSource.DataMember = "filtertb";
            // 
            // filtertbBindingSource3
            // 
            this.filtertbBindingSource3.DataMember = "filtertb";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(464, 85);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 139;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(661, 336);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.laboldpass);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsApp Marketing Tool";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lab1;
        private Guna.UI.WinForms.GunaLabel laboldpass;
        private Guna.UI.WinForms.GunaLineTextBox txtpassword;
        private Guna.UI.WinForms.GunaButton btnlogin;
        private Guna.UI.WinForms.GunaButton btmExit;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
       private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource filtertbBindingSource;
      private System.Windows.Forms.BindingSource filtertbBindingSource3;
        
     
        private System.Windows.Forms.Label label1;
         private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}

