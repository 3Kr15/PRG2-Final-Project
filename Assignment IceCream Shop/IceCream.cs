﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_IceCream_Shop
{
    abstract class IceCream
    {
		private string option;

		public string Option
		{
			get { return option; }
			set { option = value; }
		}

		private int scoops;

		public int Scoops
		{
			get { return scoops; }
			set { scoops = value; }
		}

		private List<Flavour> flavours;

		public List<Flavour> Flavours
		{
			get { return flavours; }
			set { flavours = value; }
		}

		private List<Topping> toppings;

		public List<Topping> Toppings
		{
			get { return toppings; }
			set { toppings = value; }
		}

		public IceCream() { }
		public IceCream(string o, int s, List<Flavour> f, List<Topping> t)
		{
			Option = o;
			Scoops = s;
			Flavours = f;
			Toppings = t;
		}

		public abstract double CalculatePrice();
        public override string ToString()
        {
			return "Option: " + Option + "Scoops: " + Scoops;
        }




    }
}
