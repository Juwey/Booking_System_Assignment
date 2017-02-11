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
    public partial class Resources : Form
    {
        private Rooms[] rooms = new Rooms[4];
        double[] price = new double[4];
        public Resources()
        {
            InitializeComponent();
            initialiseRooms();
            initialiseDescriptions();
            initialiseMaxCap();
            initialisePrice();
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

        private void initialiseDescriptions()
        {
            int i = 0;
            TextBox[] descriptions = { normaltbx, deluxetbx, executetbx, partytbx };
            foreach (TextBox t in descriptions)
            {
                t.Text = rooms[i].Description;
                i++;
            }
        }

        private void initialiseMaxCap()
        {
            int i = 0;
            TextBox[] MaxCapBoxes = { tbxmc1, tbxmc2, tbxmc3, tbxmc4 };
            foreach (TextBox mct in MaxCapBoxes)
            {
                mct.Text = rooms[i].MaxCapacity;
                i++;
            }
        }
        private void initialisePrice()
        {
            int i = 0;
            TextBox[] PriceBoxes = { tbxp1, tbxp2, tbxp3, tbxp4 };
            foreach (TextBox pt in PriceBoxes)
            {
                pt.Text = Convert.ToString(rooms[i].Price);
                i++;
            }
        }

        private void backbtn3_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            Hide();
        }

        private void resourcelbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
