namespace WhateverYouWant
{
    partial class ReceiptWindow
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
            this.refreshbtn = new System.Windows.Forms.Button();
            this.carttbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totaltbx = new System.Windows.Forms.TextBox();
            this.backbtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(472, 13);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(102, 37);
            this.refreshbtn.TabIndex = 0;
            this.refreshbtn.Text = "Show Receipt";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // carttbx
            // 
            this.carttbx.Location = new System.Drawing.Point(18, 62);
            this.carttbx.Margin = new System.Windows.Forms.Padding(2);
            this.carttbx.Multiline = true;
            this.carttbx.Name = "carttbx";
            this.carttbx.ReadOnly = true;
            this.carttbx.Size = new System.Drawing.Size(558, 241);
            this.carttbx.TabIndex = 1;
            this.carttbx.TextChanged += new System.EventHandler(this.carttbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Receipt";
            // 
            // totaltbx
            // 
            this.totaltbx.Location = new System.Drawing.Point(191, 319);
            this.totaltbx.Margin = new System.Windows.Forms.Padding(2);
            this.totaltbx.Name = "totaltbx";
            this.totaltbx.ReadOnly = true;
            this.totaltbx.Size = new System.Drawing.Size(384, 22);
            this.totaltbx.TabIndex = 3;
            this.totaltbx.Text = "Total Price: ";
            // 
            // backbtn2
            // 
            this.backbtn2.Location = new System.Drawing.Point(6, 7);
            this.backbtn2.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn2.Name = "backbtn2";
            this.backbtn2.Size = new System.Drawing.Size(62, 27);
            this.backbtn2.TabIndex = 4;
            this.backbtn2.Text = "Back";
            this.backbtn2.UseVisualStyleBackColor = true;
            this.backbtn2.Click += new System.EventHandler(this.backbtn2_Click);
            // 
            // ReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.backbtn2);
            this.Controls.Add(this.totaltbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carttbx);
            this.Controls.Add(this.refreshbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptWindow";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.TextBox carttbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totaltbx;
        private System.Windows.Forms.Button backbtn2;
    }
}