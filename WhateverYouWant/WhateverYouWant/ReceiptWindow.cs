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
    public partial class ReceiptWindow : Form
    {
        public ReceiptWindow()
        {
            InitializeComponent();
        }

        private void backbtn2_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            Hide();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            String cm = "";
            int i = 0;
            foreach (Resource r in Cart.getResources())
            {
                int numDays = Cart.getNumOfDays().ElementAt(i);
                cm += "Room name: " + r.Name + "\tPrice : " + r.Price + "\tNumber of Days: " + numDays + "\tTotal Price: " + r.Price * numDays + "\r\n";
                i++;
            }
            carttbx.Text = cm;

            totaltbx.Text = "Total Price for room booking is " + Cart.TotalPrice;
        }

        private void carttbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
