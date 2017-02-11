using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhateverYouWant
{
    class Rooms : Resource
    {
        private String maxCapacity;
        private String description;


        public Rooms(String maxCapacity, string description, string r_name, double r_price, int r_qty) : base(r_name, r_price, r_qty)
        {
            this.maxCapacity = maxCapacity;
            this.description = description;
        }

        public String MaxCapacity
        {
            get { return this.maxCapacity; }
            set { this.maxCapacity = value; }
        }

        public String Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

    }
}
