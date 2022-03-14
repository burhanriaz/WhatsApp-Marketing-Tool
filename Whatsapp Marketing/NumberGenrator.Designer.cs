namespace Whatsapp_Marketing
{
    partial class NumberGenrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberGenrator));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtcountryNameCb = new Guna.UI.WinForms.GunaComboBox();
            this.txtquantity = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnGenrate = new Guna.UI.WinForms.GunaButton();
            this.txtpattren = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lab3 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnsendMessage = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumberDGV = new System.Windows.Forms.DataGridView();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtcountrycodeCb = new Guna.UI.WinForms.GunaComboBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 78;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderSize = 3;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.ImageSize = new System.Drawing.Size(39, 39);
            this.btnDelete.Location = new System.Drawing.Point(593, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Red;
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(187, 42);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Animated = true;
            this.btnsave.AnimationHoverSpeed = 0.07F;
            this.btnsave.AnimationSpeed = 0.03F;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsave.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnsave.BorderColor = System.Drawing.Color.White;
            this.btnsave.BorderSize = 3;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.FocusedColor = System.Drawing.Color.Transparent;
            this.btnsave.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.ImageSize = new System.Drawing.Size(33, 33);
            this.btnsave.Location = new System.Drawing.Point(199, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Red;
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(187, 42);
            this.btnsave.TabIndex = 72;
            this.btnsave.Text = "Export";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(70, 132);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(103, 17);
            this.gunaLabel5.TabIndex = 70;
            this.gunaLabel5.Text = "Country Name";
            // 
            // txtcountryNameCb
            // 
            this.txtcountryNameCb.BackColor = System.Drawing.Color.Transparent;
            this.txtcountryNameCb.BaseColor = System.Drawing.Color.White;
            this.txtcountryNameCb.BorderColor = System.Drawing.Color.Silver;
            this.txtcountryNameCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcountryNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcountryNameCb.FocusedColor = System.Drawing.Color.Empty;
            this.txtcountryNameCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcountryNameCb.ForeColor = System.Drawing.Color.Black;
            this.txtcountryNameCb.FormattingEnabled = true;
            this.txtcountryNameCb.Location = new System.Drawing.Point(188, 129);
            this.txtcountryNameCb.Name = "txtcountryNameCb";
            this.txtcountryNameCb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcountryNameCb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcountryNameCb.Size = new System.Drawing.Size(160, 26);
            this.txtcountryNameCb.TabIndex = 69;
            this.txtcountryNameCb.SelectedIndexChanged += new System.EventHandler(this.txtcountryNameCb_SelectedIndexChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtquantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.ForeColor = System.Drawing.Color.White;
            this.txtquantity.LineColor = System.Drawing.Color.White;
            this.txtquantity.Location = new System.Drawing.Point(188, 265);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(160, 29);
            this.txtquantity.TabIndex = 68;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(72, 277);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(64, 17);
            this.gunaLabel4.TabIndex = 67;
            this.gunaLabel4.Text = "Quantity";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // btnGenrate
            // 
            this.btnGenrate.Animated = true;
            this.btnGenrate.AnimationHoverSpeed = 0.07F;
            this.btnGenrate.AnimationSpeed = 0.03F;
            this.btnGenrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenrate.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnGenrate.BorderColor = System.Drawing.Color.White;
            this.btnGenrate.BorderSize = 3;
            this.btnGenrate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenrate.FocusedColor = System.Drawing.Color.Transparent;
            this.btnGenrate.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrate.ForeColor = System.Drawing.Color.White;
            this.btnGenrate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenrate.Image")));
            this.btnGenrate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenrate.ImageOffsetX = 1;
            this.btnGenrate.ImageSize = new System.Drawing.Size(41, 41);
            this.btnGenrate.Location = new System.Drawing.Point(2, 5);
            this.btnGenrate.Name = "btnGenrate";
            this.btnGenrate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenrate.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnGenrate.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGenrate.OnHoverImage = null;
            this.btnGenrate.OnPressedColor = System.Drawing.Color.Red;
            this.btnGenrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGenrate.Size = new System.Drawing.Size(187, 42);
            this.btnGenrate.TabIndex = 66;
            this.btnGenrate.Text = "Genrate";
            this.btnGenrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenrate.Click += new System.EventHandler(this.btnGenrate_Click);
            // 
            // txtpattren
            // 
            this.txtpattren.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtpattren.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpattren.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtpattren.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpattren.ForeColor = System.Drawing.Color.White;
            this.txtpattren.LineColor = System.Drawing.Color.White;
            this.txtpattren.Location = new System.Drawing.Point(188, 218);
            this.txtpattren.Name = "txtpattren";
            this.txtpattren.PasswordChar = '\0';
            this.txtpattren.SelectedText = "";
            this.txtpattren.Size = new System.Drawing.Size(160, 29);
            this.txtpattren.TabIndex = 64;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(69, 233);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 17);
            this.gunaLabel2.TabIndex = 63;
            this.gunaLabel2.Text = "Number Pattren";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(69, 186);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(100, 17);
            this.gunaLabel1.TabIndex = 62;
            this.gunaLabel1.Text = "Country Code";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lab3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lab3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.ForeColor = System.Drawing.Color.Black;
            this.lab3.Location = new System.Drawing.Point(70, 73);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(194, 26);
            this.lab3.TabIndex = 81;
            this.lab3.Text = "Gentrate Number";
            this.lab3.Click += new System.EventHandler(this.lab3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 10);
            this.panel3.TabIndex = 84;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Black;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(10, 440);
            this.gunaPanel2.TabIndex = 80;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderSize = 3;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(231, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Red;
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(117, 40);
            this.btnRefresh.TabIndex = 61;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnsendMessage
            // 
            this.btnsendMessage.Animated = true;
            this.btnsendMessage.AnimationHoverSpeed = 0.07F;
            this.btnsendMessage.AnimationSpeed = 0.03F;
            this.btnsendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsendMessage.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnsendMessage.BorderColor = System.Drawing.Color.White;
            this.btnsendMessage.BorderSize = 3;
            this.btnsendMessage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsendMessage.FocusedColor = System.Drawing.Color.Transparent;
            this.btnsendMessage.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsendMessage.ForeColor = System.Drawing.Color.White;
            this.btnsendMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnsendMessage.Image")));
            this.btnsendMessage.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsendMessage.Location = new System.Drawing.Point(396, 5);
            this.btnsendMessage.Name = "btnsendMessage";
            this.btnsendMessage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsendMessage.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnsendMessage.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnsendMessage.OnHoverImage = null;
            this.btnsendMessage.OnPressedColor = System.Drawing.Color.Red;
            this.btnsendMessage.Size = new System.Drawing.Size(187, 42);
            this.btnsendMessage.TabIndex = 75;
            this.btnsendMessage.Text = "Send Message";
            this.btnsendMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnsendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnGenrate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnsendMessage);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 55);
            this.panel1.TabIndex = 110;
            // 
            // NumberDGV
            // 
            this.NumberDGV.AllowUserToAddRows = false;
            this.NumberDGV.AllowUserToDeleteRows = false;
            this.NumberDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NumberDGV.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.NumberDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumberDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NumberDGV.Location = new System.Drawing.Point(395, 104);
            this.NumberDGV.Name = "NumberDGV";
            this.NumberDGV.ReadOnly = true;
            this.NumberDGV.Size = new System.Drawing.Size(386, 302);
            this.NumberDGV.TabIndex = 117;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gunaLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(518, 73);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(133, 19);
            this.gunaLabel7.TabIndex = 119;
            this.gunaLabel7.Text = "Filter Number List";
            // 
            // txtcountrycodeCb
            // 
            this.txtcountrycodeCb.BackColor = System.Drawing.Color.Transparent;
            this.txtcountrycodeCb.BaseColor = System.Drawing.Color.White;
            this.txtcountrycodeCb.BorderColor = System.Drawing.Color.Silver;
            this.txtcountrycodeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcountrycodeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcountrycodeCb.FocusedColor = System.Drawing.Color.Empty;
            this.txtcountrycodeCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcountrycodeCb.ForeColor = System.Drawing.Color.Black;
            this.txtcountrycodeCb.FormattingEnabled = true;
            this.txtcountrycodeCb.Location = new System.Drawing.Point(188, 177);
            this.txtcountrycodeCb.Name = "txtcountrycodeCb";
            this.txtcountrycodeCb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcountrycodeCb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtcountrycodeCb.Size = new System.Drawing.Size(160, 26);
            this.txtcountrycodeCb.TabIndex = 120;
            this.txtcountrycodeCb.SelectedIndexChanged += new System.EventHandler(this.txtcountrycodeCb_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExit.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.BorderSize = 3;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(83, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Red;
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(117, 40);
            this.btnExit.TabIndex = 121;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NumberGenrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtcountrycodeCb);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.NumberDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtcountryNameCb);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtpattren);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NumberGenrator";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsApp Marketing";
            this.Load += new System.EventHandler(this.NumberGenrator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnsave;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaComboBox txtcountryNameCb;
        private Guna.UI.WinForms.GunaLineTextBox txtquantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnGenrate;
        private Guna.UI.WinForms.GunaLineTextBox txtpattren;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lab3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton btnsendMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView NumberDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox txtcountrycodeCb;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}