namespace WhateverYouWant
{
    partial class MainPage
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
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.bookingbtn = new System.Windows.Forms.Button();
            this.resourcebtn = new System.Windows.Forms.Button();
            this.cartbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(122, 24);
            this.Welcomelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(122, 29);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome";
            this.Welcomelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.Location = new System.Drawing.Point(103, 101);
            this.bookingbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(142, 40);
            this.bookingbtn.TabIndex = 1;
            this.bookingbtn.Text = "KTV Booking";
            this.bookingbtn.UseVisualStyleBackColor = true;
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // resourcebtn
            // 
            this.resourcebtn.Location = new System.Drawing.Point(104, 174);
            this.resourcebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resourcebtn.Name = "resourcebtn";
            this.resourcebtn.Size = new System.Drawing.Size(142, 40);
            this.resourcebtn.TabIndex = 2;
            this.resourcebtn.Text = "Resources";
            this.resourcebtn.UseVisualStyleBackColor = true;
            this.resourcebtn.Click += new System.EventHandler(this.resourcebtn_Click);
            // 
            // cartbtn
            // 
            this.cartbtn.Location = new System.Drawing.Point(102, 252);
            this.cartbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(142, 38);
            this.cartbtn.TabIndex = 3;
            this.cartbtn.Text = "Receipt";
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 347);
            this.Controls.Add(this.cartbtn);
            this.Controls.Add(this.resourcebtn);
            this.Controls.Add(this.bookingbtn);
            this.Controls.Add(this.Welcomelbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Button bookingbtn;
        private System.Windows.Forms.Button resourcebtn;
        private System.Windows.Forms.Button cartbtn;
    }
}

