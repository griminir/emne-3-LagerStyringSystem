using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emne_3_LagerStyringSystem
{
    public interface IProduct
    {
        string Navn { get; set; }
        double Pris { get; set; }
    }
}
