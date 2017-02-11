using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhateverYouWant
{
    public partial class KTVBooking : Form
    {
        private Rooms[] rooms = new Rooms[4];
        double[] Price = new double[4];
        double[] TPrice = new double[4];
        int[] numDays = new int[4];
        public KTVBooking()
        {
            InitializeComponent();
            initialiseRooms();
        }

        private void initialiseRooms()
        {
            int i = 0;
            foreach (String str in File.ReadAllLines("resource.txt"))
            {
                String roomName = str.Split('+')[0];
                double roomPrice = Convert.ToDouble(str.Split('+')[1]);
                int roomQty = Convert.ToInt32(str.Split('+')[2]);
                String MaxCap = str.Split('+')[3];
                String desc = str.Split('+')[4];
                rooms[i] = new Rooms(MaxCap, desc, roomName, roomPrice, roomQty);
                i++;
            }
        }
        private void pricelbl_Click(object sender, EventArgs e)
        {

        }

        private void backbtn1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            Hide();
        }

        //private void roomtypecmbx_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox c = (ComboBox)sender;
        //    int selectedIndex = c.SelectedIndex;
        //    switch (selectedIndex)
        //    {
        //        case 0:
        //            Price[0] = 15;
        //            break;
        //        case 1:
        //            Price[0] = 20;
        //            break;
        //        case 2:
        //            Price[0] = 35;
        //            break;
        //        case 3:
        //            Price[0] = 100;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void dtpstart1_ValueChanged(object sender, EventArgs e)
        {
            numDays[0] = 1 + Convert.ToInt32((dtpend1.Value - dtpstart1.Value).TotalDays);
            tbxtp1.Text = (numDays[0] * rooms[0].Price).ToString();
            TPrice[0] = Convert.ToDouble(tbxtp1.Text);
        }

        private void dtpend1_ValueChanged(object sender, EventArgs e)
        {
            numDays[0] = 1 + Convert.ToInt32((dtpend1.Value - dtpstart1.Value).TotalDays);
            tbxtp1.Text = (numDays[0] * rooms[0].Price).ToString();
            TPrice[0] = Convert.ToDouble(tbxtp1.Text);
        }

        private void dtpstart2_ValueChanged(object sender, EventArgs e)
        {
            numDays[1] = 1 + Convert.ToInt32((dtpend2.Value - dtpstart2.Value).TotalDays);
            tbxtp2.Text = (numDays[1] * rooms[1].Price).ToString();
            TPrice[1] = Convert.ToDouble(tbxtp2.Text);
        }

        private void dtpend2_ValueChanged(object sender, EventArgs e)
        {
            numDays[1] = 1 + Convert.ToInt32((dtpend2.Value - dtpstart2.Value).TotalDays);
            tbxtp2.Text = (numDays[1] * rooms[1].Price).ToString();
            TPrice[1] = Convert.ToDouble(tbxtp2.Text);
        }

        private void dtpstart3_ValueChanged(object sender, EventArgs e)
        {
            numDays[2] = 1 + Convert.ToInt32((dtpend3.Value - dtpstart3.Value).TotalDays);
            tbxtp3.Text = (numDays[2] * rooms[2].Price).ToString();
            TPrice[2] = Convert.ToDouble(tbxtp3.Text);
        }

        private void dtpend3_ValueChanged(object sender, EventArgs e)
        {
            numDays[2] = 1 + Convert.ToInt32((dtpend3.Value - dtpstart3.Value).TotalDays);
            tbxtp3.Text = (numDays[2] * rooms[2].Price).ToString();
            TPrice[2] = Convert.ToDouble(tbxtp3.Text);
        }

        private void dtpstart4_ValueChanged(object sender, EventArgs e)
        {
            numDays[3] = 1 + Convert.ToInt32((dtpend4.Value - dtpstart4.Value).TotalDays);
            tbxtp4.Text = (numDays[3] * rooms[3].Price).ToString();
            TPrice[3] = Convert.ToDouble(tbxtp4.Text);
        }

        private void dtpend4_ValueChanged(object sender, EventArgs e)
        {
            numDays[3] = 1 + Convert.ToInt32((dtpend4.Value - dtpstart4.Value).TotalDays);
            tbxtp4.Text = (numDays[3] * rooms[3].Price).ToString();
            TPrice[3] = Convert.ToDouble(tbxtp4.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Cart.addToCart(rooms[0], numDays[0]);
            MessageBox.Show("Room Booked!", "Purchase Message");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Cart.addToCart(rooms[1], numDays[1]);
            MessageBox.Show("Room Booked!", "Purchase Message");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Cart.addToCart(rooms[2], numDays[2]);
            MessageBox.Show("Room Booked!", "Purchase Message");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Cart.addToCart(rooms[3], numDays[3]);
            MessageBox.Show("Room Booked!", "Purchase Message");
        }
    }
}
