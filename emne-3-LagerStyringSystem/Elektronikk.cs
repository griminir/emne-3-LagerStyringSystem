using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    public class Elektronikk : IProduct
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Garanti { get; set; }

        public Elektronikk(string navn, double price, string garanti)
        {
            Navn = navn;
            Pris = price;
            Garanti = garanti;
        }

        public Elektronikk()
        {
            
        }

        public IProduct AddProduct(string name, double price, string granati)
        {
            return new Elektronikk(name, price, granati);
        }
    }
}
