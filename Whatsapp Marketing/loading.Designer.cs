﻿namespace Whatsapp_Marketing
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogress = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.percentage = new System.Windows.Forms.Label();
            this.Mycar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Design By Burhan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "WhatsApp Marketing Tool";
            // 
            // Myprogress
            // 
            this.Myprogress.Animated = true;
            this.Myprogress.AnimationSpeed = 0.6F;
            this.Myprogress.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Myprogress.BaseColor = System.Drawing.Color.MediumTurquoise;
            this.Myprogress.Controls.Add(this.percentage);
            this.Myprogress.Controls.Add(this.Mycar);
            this.Myprogress.ForeColor = System.Drawing.Color.White;
            this.Myprogress.IdleColor = System.Drawing.Color.DarkCyan;
            this.Myprogress.IdleOffset = 20;
            this.Myprogress.IdleThickness = 10;
            this.Myprogress.Image = null;
            this.Myprogress.ImageSize = new System.Drawing.Size(52, 52);
            this.Myprogress.Location = new System.Drawing.Point(234, 84);
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressMaxColor = System.Drawing.Color.White;
            this.Myprogress.ProgressMinColor = System.Drawing.Color.White;
            this.Myprogress.ProgressOffset = 20;
            this.Myprogress.ProgressThickness = 8;
            this.Myprogress.Size = new System.Drawing.Size(197, 194);
            this.Myprogress.TabIndex = 4;
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.White;
            this.percentage.Location = new System.Drawing.Point(91, 150);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(19, 16);
            this.percentage.TabIndex = 4;
            this.percentage.Text = "%";
            // 
            // Mycar
            // 
            this.Mycar.BaseColor = System.Drawing.Color.DarkSlateGray;
            this.Mycar.Image = ((System.Drawing.Image)(resources.GetObject("Mycar.Image")));
            this.Mycar.Location = new System.Drawing.Point(43, 44);
            this.Mycar.Name = "Mycar";
            this.Mycar.Size = new System.Drawing.Size(111, 104);
            this.Mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mycar.TabIndex = 2;
            this.Mycar.TabStop = false;
            this.Mycar.UseTransfarantBackground = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(671, 369);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Myprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loading_Load);
            this.Myprogress.ResumeLayout(false);
            this.Myprogress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleProgressBar Myprogress;
        private System.Windows.Forms.Label percentage;
        private Guna.UI.WinForms.GunaCirclePictureBox Mycar;
        private System.Windows.Forms.Timer timer1;
    }
}