using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhateverYouWant
{
    class Resource
    {
        private string name;
        private double price;
        private int qty;
        public double tprice;

        public Resource(string r_name, double r_price, int r_qty)
        {
            this.name = r_name;
            this.price = r_price;
            this.qty = r_qty;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Qty
        {
            get { return this.qty; }
            set { this.qty = value; }
        }

        public double TPrice
        {
            get { return this.tprice; }
            set { this.tprice = value; }
        }
    }
}
