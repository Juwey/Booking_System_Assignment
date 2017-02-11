using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhateverYouWant
{
    static class Cart
    {
        static List<Resource> resources = new List<Resource>();
        static List<int> numDays = new List<int>();
        static double TPrice = 0;

        public static void addToCart(Resource r, int days)
        {
            resources.Add(r);
            numDays.Add(days);
            TPrice += r.Price * days;
        }

        public static List<Resource> getResources()
        {
            return resources;
        }

        public static List<int> getNumOfDays()
        {
            return numDays;
        }

        public static double TotalPrice
        {
            get { return TPrice; }
            set { TPrice = value; }
        }
    }
}
