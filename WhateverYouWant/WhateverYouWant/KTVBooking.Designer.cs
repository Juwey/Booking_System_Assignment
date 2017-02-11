namespace WhateverYouWant
{
    partial class KTVBooking
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
            this.bookinglbl = new System.Windows.Forms.Label();
            this.backbtn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.tbxtp1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.dtpend1 = new System.Windows.Forms.DateTimePicker();
            this.dtpstart1 = new System.Windows.Forms.DateTimePicker();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.tbxtp2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.dtpend2 = new System.Windows.Forms.DateTimePicker();
            this.dtpstart2 = new System.Windows.Forms.DateTimePicker();
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.tbxtp3 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.dtpend3 = new System.Windows.Forms.DateTimePicker();
            this.dtpstart3 = new System.Windows.Forms.DateTimePicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.gbx4 = new System.Windows.Forms.GroupBox();
            this.tbxtp4 = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.dtpend4 = new System.Windows.Forms.DateTimePicker();
            this.dtpstart4 = new System.Windows.Forms.DateTimePicker();
            this.lbl4 = new System.Windows.Forms.Label();
            this.gbx1.SuspendLayout();
            this.gbx2.SuspendLayout();
            this.gbx3.SuspendLayout();
            this.gbx4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookinglbl
            // 
            this.bookinglbl.AutoSize = true;
            this.bookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinglbl.Location = new System.Drawing.Point(193, 47);
            this.bookinglbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookinglbl.Name = "bookinglbl";
            this.bookinglbl.Size = new System.Drawing.Size(119, 31);
            this.bookinglbl.TabIndex = 0;
            this.bookinglbl.Text = "Booking";
            // 
            // backbtn1
            // 
            this.backbtn1.Location = new System.Drawing.Point(6, 7);
            this.backbtn1.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn1.Name = "backbtn1";
            this.backbtn1.Size = new System.Drawing.Size(60, 26);
            this.backbtn1.TabIndex = 4;
            this.backbtn1.Text = "Back";
            this.backbtn1.UseVisualStyleBackColor = true;
            this.backbtn1.Click += new System.EventHandler(this.backbtn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(16, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 17);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Date slots:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 31);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(75, 17);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Date slots:";
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.tbxtp1);
            this.gbx1.Controls.Add(this.btn1);
            this.gbx1.Controls.Add(this.dtpend1);
            this.gbx1.Controls.Add(this.dtpstart1);
            this.gbx1.Controls.Add(this.lbl1);
            this.gbx1.Location = new System.Drawing.Point(22, 81);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(500, 150);
            this.gbx1.TabIndex = 7;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Normal";
            // 
            // tbxtp1
            // 
            this.tbxtp1.Location = new System.Drawing.Point(192, 109);
            this.tbxtp1.Name = "tbxtp1";
            this.tbxtp1.ReadOnly = true;
            this.tbxtp1.Size = new System.Drawing.Size(169, 22);
            this.tbxtp1.TabIndex = 9;
            this.tbxtp1.TabStop = false;
            this.tbxtp1.Text = "Total price";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(385, 54);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 23);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Book now!";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dtpend1
            // 
            this.dtpend1.Location = new System.Drawing.Point(117, 71);
            this.dtpend1.Name = "dtpend1";
            this.dtpend1.Size = new System.Drawing.Size(244, 22);
            this.dtpend1.TabIndex = 7;
            this.dtpend1.ValueChanged += new System.EventHandler(this.dtpend1_ValueChanged);
            // 
            // dtpstart1
            // 
            this.dtpstart1.Location = new System.Drawing.Point(117, 33);
            this.dtpstart1.Name = "dtpstart1";
            this.dtpstart1.Size = new System.Drawing.Size(244, 22);
            this.dtpstart1.TabIndex = 6;
            this.dtpstart1.ValueChanged += new System.EventHandler(this.dtpstart1_ValueChanged);
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.tbxtp2);
            this.gbx2.Controls.Add(this.btn2);
            this.gbx2.Controls.Add(this.dtpend2);
            this.gbx2.Controls.Add(this.dtpstart2);
            this.gbx2.Controls.Add(this.lbl2);
            this.gbx2.Location = new System.Drawing.Point(22, 248);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(500, 150);
            this.gbx2.TabIndex = 8;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Deluxe";
            // 
            // tbxtp2
            // 
            this.tbxtp2.Location = new System.Drawing.Point(192, 108);
            this.tbxtp2.Name = "tbxtp2";
            this.tbxtp2.ReadOnly = true;
            this.tbxtp2.Size = new System.Drawing.Size(169, 22);
            this.tbxtp2.TabIndex = 10;
            this.tbxtp2.TabStop = false;
            this.tbxtp2.Text = "Total price";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(385, 51);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 23);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Book now!";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dtpend2
            // 
            this.dtpend2.Location = new System.Drawing.Point(117, 68);
            this.dtpend2.Name = "dtpend2";
            this.dtpend2.Size = new System.Drawing.Size(244, 22);
            this.dtpend2.TabIndex = 8;
            this.dtpend2.ValueChanged += new System.EventHandler(this.dtpend2_ValueChanged);
            // 
            // dtpstart2
            // 
            this.dtpstart2.Location = new System.Drawing.Point(117, 31);
            this.dtpstart2.Name = "dtpstart2";
            this.dtpstart2.Size = new System.Drawing.Size(244, 22);
            this.dtpstart2.TabIndex = 7;
            this.dtpstart2.ValueChanged += new System.EventHandler(this.dtpstart2_ValueChanged);
            // 
            // gbx3
            // 
            this.gbx3.Controls.Add(this.tbxtp3);
            this.gbx3.Controls.Add(this.btn3);
            this.gbx3.Controls.Add(this.dtpend3);
            this.gbx3.Controls.Add(this.dtpstart3);
            this.gbx3.Controls.Add(this.lbl3);
            this.gbx3.Location = new System.Drawing.Point(22, 421);
            this.gbx3.Name = "gbx3";
            this.gbx3.Size = new System.Drawing.Size(500, 150);
            this.gbx3.TabIndex = 9;
            this.gbx3.TabStop = false;
            this.gbx3.Text = "Executive";
            // 
            // tbxtp3
            // 
            this.tbxtp3.Location = new System.Drawing.Point(192, 118);
            this.tbxtp3.Name = "tbxtp3";
            this.tbxtp3.ReadOnly = true;
            this.tbxtp3.Size = new System.Drawing.Size(169, 22);
            this.tbxtp3.TabIndex = 4;
            this.tbxtp3.TabStop = false;
            this.tbxtp3.Text = "Total price";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(385, 70);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Book now!";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // dtpend3
            // 
            this.dtpend3.Location = new System.Drawing.Point(117, 89);
            this.dtpend3.Name = "dtpend3";
            this.dtpend3.Size = new System.Drawing.Size(244, 22);
            this.dtpend3.TabIndex = 2;
            this.dtpend3.ValueChanged += new System.EventHandler(this.dtpend3_ValueChanged);
            // 
            // dtpstart3
            // 
            this.dtpstart3.Location = new System.Drawing.Point(117, 50);
            this.dtpstart3.Name = "dtpstart3";
            this.dtpstart3.Size = new System.Drawing.Size(244, 22);
            this.dtpstart3.TabIndex = 1;
            this.dtpstart3.ValueChanged += new System.EventHandler(this.dtpstart3_ValueChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(16, 50);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(75, 17);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Date slots:";
            // 
            // gbx4
            // 
            this.gbx4.Controls.Add(this.tbxtp4);
            this.gbx4.Controls.Add(this.btn4);
            this.gbx4.Controls.Add(this.dtpend4);
            this.gbx4.Controls.Add(this.dtpstart4);
            this.gbx4.Controls.Add(this.lbl4);
            this.gbx4.Location = new System.Drawing.Point(22, 590);
            this.gbx4.Name = "gbx4";
            this.gbx4.Size = new System.Drawing.Size(500, 150);
            this.gbx4.TabIndex = 10;
            this.gbx4.TabStop = false;
            this.gbx4.Text = "Party";
            // 
            // tbxtp4
            // 
            this.tbxtp4.Location = new System.Drawing.Point(192, 106);
            this.tbxtp4.Name = "tbxtp4";
            this.tbxtp4.ReadOnly = true;
            this.tbxtp4.Size = new System.Drawing.Size(169, 22);
            this.tbxtp4.TabIndex = 4;
            this.tbxtp4.TabStop = false;
            this.tbxtp4.Text = "Total price";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(385, 43);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Book now!";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // dtpend4
            // 
            this.dtpend4.Location = new System.Drawing.Point(117, 67);
            this.dtpend4.Name = "dtpend4";
            this.dtpend4.Size = new System.Drawing.Size(244, 22);
            this.dtpend4.TabIndex = 2;
            this.dtpend4.ValueChanged += new System.EventHandler(this.dtpend4_ValueChanged);
            // 
            // dtpstart4
            // 
            this.dtpstart4.Location = new System.Drawing.Point(117, 29);
            this.dtpstart4.Name = "dtpstart4";
            this.dtpstart4.Size = new System.Drawing.Size(244, 22);
            this.dtpstart4.TabIndex = 1;
            this.dtpstart4.ValueChanged += new System.EventHandler(this.dtpstart4_ValueChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(16, 29);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(75, 17);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "Date slots:";
            // 
            // KTVBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 479);
            this.Controls.Add(this.gbx4);
            this.Controls.Add(this.gbx3);
            this.Controls.Add(this.gbx2);
            this.Controls.Add(this.gbx1);
            this.Controls.Add(this.backbtn1);
            this.Controls.Add(this.bookinglbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KTVBooking";
            this.Text = "KTVBooking";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            this.gbx4.ResumeLayout(false);
            this.gbx4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookinglbl;
        private System.Windows.Forms.Button backbtn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DateTimePicker dtpend1;
        private System.Windows.Forms.DateTimePicker dtpstart1;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DateTimePicker dtpend2;
        private System.Windows.Forms.DateTimePicker dtpstart2;
        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DateTimePicker dtpend3;
        private System.Windows.Forms.DateTimePicker dtpstart3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox gbx4;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.DateTimePicker dtpend4;
        private System.Windows.Forms.DateTimePicker dtpstart4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbxtp1;
        private System.Windows.Forms.TextBox tbxtp2;
        private System.Windows.Forms.TextBox tbxtp3;
        private System.Windows.Forms.TextBox tbxtp4;
    }
}