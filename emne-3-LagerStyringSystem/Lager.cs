using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    public class Lager
    {
        private List<IProduct> _items = new List<IProduct>();
        private IProduct _Product;

        public void AddProduct(IProduct product, string name, double price, string attribute)
        {
            _Product = product;

            _items.Add(_Product.AddProduct(name, price, attribute));
        }

        public void RemoveItem(string name)
        {
            var itemToRemove = _items.Find(n =>n.Navn == name);
            _items.Remove(itemToRemove);
        }

        public void ShowWares()
        {
            foreach (IProduct product in _items)
            {
                Console.WriteLine($"{product.Navn} {product.Pris} ");
            }
        }
    }
}
