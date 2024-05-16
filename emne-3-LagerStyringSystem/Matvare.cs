using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    internal class Matvare : IProduct
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Utløpsdato { get; set; }

        public Matvare(string name, double price, string utløpsdato)
        {
            Navn = name;
            Pris = price;
            Utløpsdato = utløpsdato;
        }

        public Matvare()
        {
            
        }

        public IProduct AddProduct(string name, double price,string utløpsdato)
        {
            return new Matvare(name, price, utløpsdato);
        }
    }
}
