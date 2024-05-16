using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    public class Lager
    {
        private List<IProduct> _products = new List<IProduct>();

        public void AddProduct(string type, string name, double price, string attribute)
        {
            if (type == "klær")
            {
                _products.Add(Klær.AddProduct(name, price, attribute));
            }
            else if (type == "elektronikk")
            {
                _products.Add(Elektronikk.AddProduct(name, price, attribute));
            }
            else if (type == "matvare")
            {
                _products.Add(Matvare.AddProduct(name, price, attribute));
            }
        }

        public void RemoveItem(string name)
        {
            var itemToRemove = _products.Find(n =>n.Navn == name);
            _products.Remove(itemToRemove);
        }

        public void ShowWares()
        {
            foreach (IProduct product in _products)
            {
                Console.WriteLine($"{product.Navn} {product.Pris} ");
            }
        }
    }
}
