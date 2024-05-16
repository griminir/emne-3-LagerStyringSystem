using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    internal class Klær : IProduct
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Størrelse { get; set;}

        public Klær(string name, double price, string size)
        {
            Navn = name;
            Pris = price;
            Størrelse = size;
        }

        public Klær()
        {
            
        }

        public IProduct AddProduct(string name, double price, string size)
        {
            return new Klær(name, price, size);
        }
    }
}
