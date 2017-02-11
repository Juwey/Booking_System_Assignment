using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhateverYouWant
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            KTVBooking KTVB = new KTVBooking();
            KTVB.Show();
            Hide();
        }

        private void resourcebtn_Click(object sender, EventArgs e)
        {
            Resources res = new Resources();
            res.Show();
            Hide();
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            ReceiptWindow cart = new ReceiptWindow();
            cart.Show();
            Hide();
        }
    }
}
